
using System;
using System.Windows.Forms;

namespace DataAccess
{
    public class Usuario
    {
        public int id_usuario {  get; set; }
        public string nombre { get; set;}
        public DateTime fecha_creacion_usuario{ get; set;}
        public string contrasena { get; set;}
    }
}
