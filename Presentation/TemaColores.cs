using System;
using System.Drawing;

namespace Presentation
{
    public static class TemaColores
    {
        public static Color BarraTitulo;
        public static Color PanelContenedor;
        public static Color MenuVertical;
        public static Color btn_eliminar;
        public static Color btn_guardar;
        public static Color btn_volver;

        // Definición de colores por temas

        // Defecto
        private static readonly Color BarraTituloD = Color.FromArgb(186, 54, 85);
        private static readonly Color PanelContenedorD = Color.FromArgb(59, 17, 27);
        private static readonly Color MenuVerticalD = Color.FromArgb(122, 35, 56);
        private static readonly Color btn_eliminarD = Color.Red;
        private static readonly Color btn_guardarD = Color.Green;
        private static readonly Color btn_volverD = Color.Blue;

        // Morado
        private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);
        private static readonly Color PanelContenedorM = Color.FromArgb(92, 36, 97);
        private static readonly Color MenuVerticalM = Color.FromArgb(94, 65, 97);
        private static readonly Color btn_eliminarM = Color.Purple;
        private static readonly Color btn_guardarM = Color.Magenta;
        private static readonly Color btn_volverM = Color.Lavender;

        // Verde
        private static readonly Color BarraTituloV = Color.FromArgb(157, 224, 0);
        private static readonly Color PanelContenedorV = Color.FromArgb(71, 102, 0);
        private static readonly Color MenuVerticalV = Color.FromArgb(121, 173, 0);
        private static readonly Color btn_eliminarV = Color.Lime;
        private static readonly Color btn_guardarV = Color.Olive;
        private static readonly Color btn_volverV = Color.Teal;

        // Agregar más temas según sea necesario

        // Método para elegir y aplicar el tema
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
                    // Agregar más casos según sea necesario
            }
        }
    }
}
