using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace DataAccess
{
    // Clase de conexión
    public class ConnectionToSQLite
    {
        private SQLiteConnection conexion;

        // Constructor que detecta la ubicación del archivo y construye la ruta relativa
        public ConnectionToSQLite()
        {
            ObtenerRuta();
        }

        // Detecta la ruta y la asigna
        public void ObtenerRuta()
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string basePath = Path.GetDirectoryName(assemblyLocation);
            string projectFolderPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\.."));

            string fullPath = Path.Combine(projectFolderPath, "BBDD\\cleandbuild.db");
            conexion = new SQLiteConnection($"Data Source={fullPath};");
        }

        // Método para establecer la conexión
        public SQLiteConnection Conectar()
        {
            ObtenerRuta();
            return conexion;
        }

        // Método para cerrar la conexión
        public void Desconectar()
        {
            if (conexion != null && conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }
}
