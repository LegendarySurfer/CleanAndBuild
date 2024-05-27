using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Xml.Linq;

namespace DataAccess
{
    public class UserDao : ConnectionToSQLite
    {
        //comprueba si hay bbdd
        public bool ComprobarBBDD()
        {
            return File.Exists(RutaBBDD());
        }

        //creamos las tablas de la bbdd y el usuario administrador
        public void CrearBBDD()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS persona (
                nombre TEXT,
                id_usuario INTEGER PRIMARY KEY AUTOINCREMENT,
                fecha_creacion_registro DATE NOT NULL,
                contraseña TEXT NOT NULL,
                es_administrador BOOLEAN NOT NULL CHECK (es_administrador IN (0, 1))
            );

            CREATE TABLE IF NOT EXISTS comando (
                id_comando INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre_comando TEXT NOT NULL,
                logica_comando TEXT NOT NULL,
                comando_creado BOOLEAN NOT NULL CHECK (comando_creado IN (0, 1))
            );

            CREATE TABLE IF NOT EXISTS historial (
                fecha_ejecutado DATE PRIMARY KEY NOT NULL,
                id_persona INTEGER NOT NULL,
                id_comando INTEGER NOT NULL,
                FOREIGN KEY (id_persona) REFERENCES persona(id_usuario) ON DELETE CASCADE,
                FOREIGN KEY (id_comando) REFERENCES comando(id_comando)
            );

            CREATE TABLE IF NOT EXISTS registra (
                fecha_ejecutado DATE PRIMARY KEY NOT NULL,
                id_persona INTEGER NOT NULL,
                id_equipo INTEGER NOT NULL,
                FOREIGN KEY (id_persona) REFERENCES persona(id_usuario) ON DELETE CASCADE,
                FOREIGN KEY (id_equipo) REFERENCES equipo(id_equipo)
            );

            CREATE TABLE IF NOT EXISTS equipo (
                id_equipo INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre_so TEXT DEFAULT 'Windows',
                nombre_equipo TEXT
            );

            CREATE TABLE IF NOT EXISTS aplicacion (
                id_aplicacion INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre_aplicacion TEXT,
                tipo TEXT
            );

            CREATE TABLE IF NOT EXISTS instalan (
                id_aplicacion INTEGER,
                id_equipo INTEGER,
                fecha_instalada DATE,
                PRIMARY KEY (id_aplicacion, id_equipo),
                FOREIGN KEY (id_aplicacion) REFERENCES aplicacion(id_aplicacion),
                FOREIGN KEY (id_equipo) REFERENCES equipo(id_equipo)
            );
        ";
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
            CrearAdmin();
        }

        public void CrearAdmin()
        {
            string generarContrasena = EncriptarContrasena("admin");
            string usuarioAdmin = @"
                INSERT INTO persona (nombre, fecha_creacion_registro, contraseña, es_administrador)
                SELECT 'admin', date('now'), @contrasena, 1
                WHERE NOT EXISTS (SELECT 1 FROM persona WHERE nombre = 'admin' AND contraseña = @contrasena);
             ";
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = usuarioAdmin;
                    comando.Parameters.AddWithValue("@contrasena", generarContrasena); // Usar el hash generado
                    comando.ExecuteNonQuery();
                }
            }
        }

        //  este método se utiliza para verificar si existe un usuario
        public bool Login(string usuario, string contrasena)
        {
            string contrasenaEncriptada = EncriptarContrasena(contrasena);
  
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM persona WHERE nombre = @usuario AND contraseña = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contrasenaEncriptada);

                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        // Método para obtener todos las aplicaciones de ese equipo
        public DataSet ObtenerAplicaciones(string nombreEquipo)
        {
            int idEquipo = ObtenerIdEquipo(nombreEquipo);

            using (var conexion = Conectar())
            {
                string query = @"
            SELECT 
                a.id_aplicacion, 
                a.nombre_aplicacion, 
                a.tipo, 
                i.fecha_instalada, 
                e.nombre_equipo
            FROM instalan i
            INNER JOIN aplicacion a ON i.id_aplicacion = a.id_aplicacion
            INNER JOIN equipo e ON i.id_equipo = e.id_equipo
            WHERE i.id_equipo = @idEquipo";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idEquipo", idEquipo);

                    using (var adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "aplicacion");
                        return datos;
                    }
                }
            }
        }

        // Método para obtener todos los comandos registrados en el historial para un usuario específico
        public DataSet ObtenerComandos(string nombreUsuario)
        {
            int idUsuario = ObtenerIdUsuario(nombreUsuario);

            using (var conexion = Conectar()) 
            {
                string query = @"
            SELECT c.nombre_comando, c.logica_comando, h.fecha_ejecutado, p.nombre
            FROM comando c
            JOIN historial h ON c.id_comando = h.id_comando
            JOIN persona p ON h.id_persona = p.id_usuario
            WHERE h.id_persona = @idUsuario";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    using (var adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "comando");
                        return datos;
                    }
                }
            }
        }

        // Método para encriptar la contraseña utilizando SHA-256
        private string EncriptarContrasena(string contrasena)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(contrasena));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        //creamos un nuevo usuario
        public void CrearNuevoUsuario(string usuario, string pass)
        {
            string contrasenaEncriptada = EncriptarContrasena(pass);

            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO persona (nombre, contraseña, fecha_creacion_registro,es_administrador) VALUES (@nombre, @contraseña, @fecha_creacion_registro,@es_administrador)";
                    comando.Parameters.AddWithValue("@nombre", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contrasenaEncriptada);
                    comando.Parameters.AddWithValue("@fecha_creacion_registro", DateTime.Now); // Agregar la fecha actual
                    comando.Parameters.AddWithValue("@es_administrador", 0);

                    comando.ExecuteNonQuery();

                }
            }
        }

        //eliminar usuario
        public void ElimiarUsuario(string name)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "DELETE FROM persona WHERE nombre = @nombree";
                    comando.Parameters.AddWithValue("@nombree", name);

                    int filasAfectadas = comando.ExecuteNonQuery();

                }
            }
        }

        //este método se utiliza para verificar si existe al menos un usuario en la base de datos cuyo nombre coincida
        //con el valor proporcionado en el argumento
        public bool CompruebaUsuario(string user)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    // Lógica para comprobar usuario
                    // Convertimos ambos lados de la comparación a minúsculas
                    comando.CommandText = "SELECT COUNT(*) FROM persona WHERE LOWER(nombre) = LOWER(@nombre)";
                    comando.Parameters.AddWithValue("@nombre", user);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        //cambiar contraseña del usuario
        public bool CambiarContrasena(string user, string pass)
        {
            string contrasenaEncriptada = EncriptarContrasena(pass);

            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "UPDATE persona SET contraseña = @NuevaContraseña WHERE nombre = @Usuario";
                    comando.Parameters.AddWithValue("@NuevaContraseña", contrasenaEncriptada);
                    comando.Parameters.AddWithValue("@Usuario", user);

                    int rowsAffected = comando.ExecuteNonQuery();

                    // Si se afectó al menos una fila, la contraseña se cambió exitosamente
                    return rowsAffected > 0;
                }
            }
        }

        //cambiar nombre de la persona
        public bool CambiarNombre(string usuarioActual, string nuevoNombre)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "UPDATE persona SET nombre = @NuevoNombre WHERE nombre = @UsuarioActual";
                    comando.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                    comando.Parameters.AddWithValue("@UsuarioActual", usuarioActual);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Si se afectó al menos una fila, el nombre se cambió exitosamente
                    return filasAfectadas > 0;
                }
            }
        }

        //este método se utiliza para verificar si existe un registro en la tabla equipo que tenga el mismo nombre que el equipo local
        public bool CompEquipo()
        {
            string nombreEquipo = Environment.MachineName;
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT COUNT(*) FROM equipo WHERE nombre_equipo = @nombreEquipo";
                    comando.Parameters.AddWithValue("@nombreEquipo", nombreEquipo);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        //agregamos un equipo y en registra
        public void AgregarEquipo()
        {
            // Llamar al método para obtener el ID de un usuario
            string nombreEquipo = Environment.MachineName;

            using (var conexion = Conectar())
            {
                conexion.Open();

                try
                {
                    // Agregar equipo a la tabla 'equipo'
                    using (var comandoEquipo = conexion.CreateCommand())
                    {
                        comandoEquipo.CommandText = "INSERT INTO equipo (nombre_so, nombre_equipo) VALUES (@nombreSO, @nombreEquipo)";
                        comandoEquipo.Parameters.AddWithValue("@nombreSO", "Windows");
                        comandoEquipo.Parameters.AddWithValue("@nombreEquipo", nombreEquipo);
                        comandoEquipo.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, manejar la excepción aquí
                    Console.WriteLine("Error al agregar equipo: " + ex.Message);
                }
            }
        }

        public void AgregarEquipoEnRegistra(string nombreusuario)
        {
            // Llamar al método para obtener el ID de un usuario
            int idUsuario = ObtenerIdUsuario(nombreusuario);
            string nombreEquipo = Environment.MachineName;

            using (var conexion = Conectar())
            {
                conexion.Open();
                try
                {
                    int idEquipo = ObtenerIdEquipo(nombreEquipo);

                    // Registrar la acción en la tabla 'registra'
                    using (var comandoRegistra = conexion.CreateCommand())
                    {
                        comandoRegistra.CommandText = "INSERT INTO registra (fecha_ejecutado, id_persona, id_equipo) VALUES (@fecha, @idPersona, @idEquipo)";
                        comandoRegistra.Parameters.AddWithValue("@fecha", DateTime.Now);
                        comandoRegistra.Parameters.AddWithValue("@idPersona", idUsuario);
                        comandoRegistra.Parameters.AddWithValue("@idEquipo", idEquipo);
                        comandoRegistra.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, manejar la excepción aquí
                    Console.WriteLine("Error al agregar equipo: " + ex.Message);
                }
            }
        }

        public DataSet ObtenerTodosLosComandos()
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM historial";

                    using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "historial");
                        return datos;
                    }
                }
            }
        }

        public void GuardarAplication(string name,string tipo)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO aplicacion (nombre_aplicacion, tipo) VALUES (@nombre_aplicacion,@tipo)";
                    comando.Parameters.AddWithValue("@nombre_aplicacion", name);
                    comando.Parameters.AddWithValue("@tipo", tipo);

                    comando.ExecuteNonQuery();

                }
            }
        }
    
        public void GuardarEnInstalan()
        {
            int idAplicacion = ObtenerIdAplicacion();
            int idEquipo = ObtenerIdEquipo(Environment.MachineName);


            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO instalan (id_aplicacion, id_equipo, fecha_instalada) VALUES (@id_aplicacion,@id_equipo,@fecha_instalada)";
                    comando.Parameters.AddWithValue("@id_aplicacion", idAplicacion);
                    comando.Parameters.AddWithValue("@id_equipo", idEquipo); 
                    comando.Parameters.AddWithValue("@fecha_instalada", DateTime.Now); 

                    comando.ExecuteNonQuery();

                }
            }
        }

        //Guardo un comando
        public void GuardarComando(string nombre_comando,string logica)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                try
                {
                    using (var comando = conexion.CreateCommand())
                    {
                        comando.CommandText = "INSERT INTO comando (nombre_comando, logica_comando,comando_creado) VALUES (@nombreComando, @logicaComando, 0)";

                        comando.Parameters.AddWithValue("@nombreComando", nombre_comando);
                        comando.Parameters.AddWithValue("@logicaComando", logica);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar equipo: " + ex.Message);
                }
            }
        }

        //Guardo un comando
        public void GuardarComandoCreado(string nombre_comando, string logica)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                try
                {
                    using (var comando = conexion.CreateCommand())
                    {
                        comando.CommandText = "INSERT INTO comando (nombre_comando, logica_comando,comando_creado) VALUES (@nombreComando, @logicaComando, 1)";

                        comando.Parameters.AddWithValue("@nombreComando", nombre_comando);
                        comando.Parameters.AddWithValue("@logicaComando", logica);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar equipo: " + ex.Message);
                }
            }
        }

        //devuelve el nombre de los comandos creados
        public DataSet DevolverComandosCreados()
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    //solo los 3 primeros
                    comando.CommandText = "SELECT * FROM comando where comando_creado = 1 ORDER BY id_comando DESC LIMIT 3";
                    using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "comando");
                        return datos;
                    }
                }
            }
        }

        public void GuardarHistorial(string nombreUsuario)
        {
            int idUsuario = ObtenerIdUsuario(nombreUsuario);

            int idComando = ObtenerIdComando();

            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO historial (fecha_ejecutado, id_persona, id_comando) VALUES (@fecha_ejecutado, @id_persona,@id_comando)";
                    
                    comando.Parameters.AddWithValue("@fecha_ejecutado", DateTime.Now); // Agregar la fecha actual
                    comando.Parameters.AddWithValue("@id_persona", idUsuario);
                    comando.Parameters.AddWithValue("@id_comando", idComando);

                    comando.ExecuteNonQuery();

                }
            }
        }

        //-------------------- OBTENER IDS -------------------------------------------
        
        // La BBDD no permite tener varios con nombre iguales por lo que no hay problema 
        public int ObtenerIdUsuario(string nombreUsuario)
        {
            int idUsuario = -1; // Valor por defecto si no se encuentra el usuario
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT id_usuario FROM persona WHERE nombre = @nombreUsuario";
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    object result = comando.ExecuteScalar();
                    if (result != null)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                }
            }
            return idUsuario;
        }

        /*
         * Puede ser que tengamos en la BBDD varios equipos con el mismo nombre(es raro)
         * Si es el caso obtendra el nombre del equipo actual y no pasara nada
         */
        public int ObtenerIdEquipo(string nombreequipo)
        {
            int idEquipo = -1; // Valor por defecto si no se encuentra el usuario
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT id_equipo FROM equipo WHERE nombre_equipo = @nombreEquipo";
                    comando.Parameters.AddWithValue("@nombreEquipo", nombreequipo);

                    object result = comando.ExecuteScalar();
                    if (result != null)
                    {
                        idEquipo = Convert.ToInt32(result);
                    }
                }
            }
            return idEquipo;
        }
        
        // Obtenemos el ultimo id de comandos
        public int ObtenerIdComando()
        { 
            int idComando = -1;

            using (var conexion = Conectar())
            {
                conexion.Open();

                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT id_comando FROM comando ORDER BY id_comando DESC LIMIT 1";

                    object result = comando.ExecuteScalar();
                    if (result != null)
                    {
                        idComando = Convert.ToInt32(result);
                    }
                }
            }

            return idComando;
        }

        //obtener el id de la ultima aplicacion instalada
        public int ObtenerIdAplicacion()
        {
            int idAplicacion = -1;

            using (var conexion = Conectar())
            {
                conexion.Open();

                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT id_aplicacion FROM aplicacion ORDER BY id_aplicacion DESC LIMIT 1";

                    object result = comando.ExecuteScalar();
                    if (result != null)
                    {
                        idAplicacion = Convert.ToInt32(result);
                    }
                }
            }

            return idAplicacion;
        }
    }
}