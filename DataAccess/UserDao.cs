using System;
using System.Data;
using System.Data.SQLite;

namespace DataAccess
{
    public class UserDao : ConnectionToSQLite
    {

        //  este método se utiliza para verificar si existe un usuario
        public bool Login(string usuario, string contrasena)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM persona WHERE nombre = @usuario AND contraseña = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contrasena);

                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        // Método para obtener todos los usuarios
        public DataSet ObtenerTodosLosUsuarios()
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM persona";

                    using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "persona");
                        return datos;
                    }
                }
            }
        }

        //creamos un nuevo usuario
        public void CrearNuevoUsuario(string usuario, string pass)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO persona (nombre, contraseña, fecha_creacion_registro,es_administrador) VALUES (@nombre, @contraseña, @fecha_creacion_registro,@es_administrador)";
                    comando.Parameters.AddWithValue("@nombre", usuario);
                    comando.Parameters.AddWithValue("@contraseña", pass);
                    comando.Parameters.AddWithValue("@fecha_creacion_registro", DateTime.Now); // Agregar la fecha actual
                    comando.Parameters.AddWithValue("@es_administrador", 0);

                    comando.ExecuteNonQuery();

                }
            }
        }

        //eliminar usuario
        public void elimiarUsuario(string name)
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
                    //logica para comprobar usuario
                    comando.CommandText = "SELECT COUNT(*) FROM persona WHERE nombre = @nombre";
                    comando.Parameters.AddWithValue("@nombre", user);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        //cambiar contraseña del usuario
        public bool CambiarContrasena(string user, string pass)
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "UPDATE persona SET contraseña = @NuevaContraseña WHERE nombre = @Usuario";
                    comando.Parameters.AddWithValue("@NuevaContraseña", pass);
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

        public DataSet ObtenerTodasLasAplicaciones()
        {
            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM aplicacion";

                    using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "aplicacion");
                        return datos;
                    }
                }
            }
        }

        public void guardarAplication(string name,string tipo)
        {
            string nombreEquipo = Environment.MachineName;

            using (var conexion = Conectar())
            {
                conexion.Open();
                using (var comando = conexion.CreateCommand())
                {
                    string id_equipo = ObtenerIdEquipo(nombreEquipo) + "";
                    comando.CommandText = "INSERT INTO aplicacion (nombre_aplicacion, tipo, fecha_instalada, id_equipo) VALUES (@nombre_aplicacion,@tipo,@fecha_instalada,@id_equipo)";
                    comando.Parameters.AddWithValue("@nombre_aplicacion", name);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@fecha_instalada", DateTime.Now); // Agregar la fecha actual
                    comando.Parameters.AddWithValue("@id_equipo", id_equipo);

                    comando.ExecuteNonQuery();

                }
            }
        }
    
    }
}