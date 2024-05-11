using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        //usuario
        public static int id_usuario {  get; set; }
        public static string nombre { get; set; }
        public static DateTime fecha_creacion_usuario { get; set; }
        public static string contrasena { get; set; }

    }
}
