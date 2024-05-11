using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class Ventana
    {

        public static void salir()
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static Panel sideBar(Panel MenuVertical)
        {
            MenuVertical.Width = (MenuVertical.Width == 333) ? 70 : 333;
            return MenuVertical;
        }
    
        public static void historial()
        {
            var historial = new Historial();
            historial.Show();
        }

        public static void opciones()
        {
            var opciones = new Ajustes();
            opciones.Show();
        }

        public static void repararSistema()
        {
            var reparar = new RepararSistema();
            reparar.Show();
        }

        public static void actualziarAplicaciones()
        {
            var actualizar = new ActualizarAplicacion();
            actualizar.Show();
        }

        public static void desfragmentarDisco()
        {
            var desfragmentar = new DesfragmentarDisco();
            desfragmentar.Show();
        }

        public static void limpiarSistema()
        {
            var limpiar = new LimpiarSistema();
            limpiar.Show();
        }

        public static void liberarEspacio()
        {
            var liberar = new LiberarEspacio();
            liberar.Show();
        }

        public static void antivirus()
        {
            var antivirus = new Antivirus();
            antivirus.Show();
        }

        public static void instalarAplicaciones()
        {
            var instalar = new InstalarAplicaciones();
            instalar.Show();
        }

        public static void menuPrincipal()
        {
            MenuPrincipal a = new MenuPrincipal(MenuPrincipal.username);
            a.Show();
        }

    }
}
