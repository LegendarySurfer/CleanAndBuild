using System;
using System.Drawing;

namespace Presentation
{
    public static class TemaColores
    {
        public static string ColorSeleccionado= "Defecto";

        public static Color BarraTitulo;
        public static Color PanelContenedor;
        public static Color MenuVertical;
        public static Color btn_eliminar;
        public static Color btn_guardar;
        public static Color btn_volver;

        // Definición de colores por temas

        // Defecto
        private static readonly Color BarraTituloD = Color.FromArgb(0,80,200);
        private static readonly Color PanelContenedorD = Color.FromArgb(49,66,82);
        private static readonly Color MenuVerticalD = Color.FromArgb(26,32,40);
        private static readonly Color btn_eliminarD = Color.FromArgb(26, 32, 40);
        private static readonly Color btn_guardarD = Color.FromArgb(106,76,147);
        private static readonly Color btn_volverD = Color.Orange;

        // Morado
        private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);
        private static readonly Color PanelContenedorM = Color.FromArgb(92, 36, 97);
        private static readonly Color MenuVerticalM = Color.FromArgb(94, 65, 97);
        private static readonly Color btn_eliminarM = Color.Purple;
        private static readonly Color btn_guardarM = Color.Magenta;
        private static readonly Color btn_volverM = Color.Lavender;

        // Verde
        private static readonly Color BarraTituloV = Color.FromArgb(40, 54, 24);
        private static readonly Color PanelContenedorV = Color.FromArgb(128, 113, 130);
        private static readonly Color MenuVerticalV = Color.FromArgb(96, 108, 56);
        private static readonly Color btn_eliminarV = Color.FromArgb(221, 161, 94);
        private static readonly Color btn_guardarV = Color.FromArgb(221, 161, 94);
        private static readonly Color btn_volverV = Color.FromArgb(188, 108, 37);


        // Verano
        private static readonly Color BarraTituloVer = Color.FromArgb(3, 71,50);
        private static readonly Color PanelContenedorVer = Color.FromArgb(0, 129, 72);
        private static readonly Color MenuVerticalVer = Color.FromArgb(198, 192, 19);
        private static readonly Color btn_eliminarVer = Color.FromArgb(239, 41, 23);
        private static readonly Color btn_guardarVer = Color.FromArgb(239, 41, 23);
        private static readonly Color btn_volverVer = Color.FromArgb(239, 138, 23);

        // Blanco
        private static readonly Color BarraTituloB = Color.FromArgb(255, 255, 255);
        private static readonly Color PanelContenedorB = Color.FromArgb(255, 255, 255);
        private static readonly Color MenuVerticalB = Color.FromArgb(255, 255, 255);
        private static readonly Color btn_eliminarB = Color.FromArgb(255, 255, 255);
        private static readonly Color btn_guardarB = Color.FromArgb(255, 255, 255);
        private static readonly Color btn_volverB = Color.FromArgb(255, 255, 255);


        public static void ElegirTema(string tema)
        {
            switch (tema)
            {
                case "Defecto":
                    BarraTitulo = BarraTituloD;
                    PanelContenedor = PanelContenedorD;
                    MenuVertical = MenuVerticalD;
                    btn_eliminar = btn_eliminarD;
                    btn_guardar = btn_guardarD;
                    btn_volver = btn_volverD;
                    break;

                case "Morado":
                    BarraTitulo = BarraTituloM;
                    PanelContenedor = PanelContenedorM;
                    MenuVertical = MenuVerticalM;
                    btn_eliminar = btn_eliminarM;
                    btn_guardar = btn_guardarM;
                    btn_volver = btn_volverM;
                    break;

                case "Verde":
                    BarraTitulo = BarraTituloV;
                    PanelContenedor = PanelContenedorV;
                    MenuVertical = MenuVerticalV;
                    btn_eliminar = btn_eliminarV;
                    btn_guardar = btn_guardarV;
                    btn_volver = btn_volverV;
                    break;

                case "Verano":
                    BarraTitulo = BarraTituloVer;
                    PanelContenedor = PanelContenedorVer;
                    MenuVertical = MenuVerticalVer;
                    btn_eliminar = btn_eliminarVer;
                    btn_guardar = btn_guardarVer;
                    btn_volver = btn_volverVer;
                    break;

                case "Blanco":
                    BarraTitulo = BarraTituloB;
                    PanelContenedor = PanelContenedorB;
                    MenuVertical = MenuVerticalB;
                    btn_eliminar = btn_eliminarB;
                    btn_guardar = btn_guardarB;
                    btn_volver = btn_volverB;
                    break;
            }
        }
    }
}
