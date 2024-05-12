using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class Ventana
    {
        public static bool PanelContraido = false;

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
            PanelContraido = MenuVertical.Width != 333; //esta contraido
            MenuVertical.Width = PanelContraido ? 333 : 70;
            return MenuVertical;
        }
    
        public static void historial()
        {
            var historial = new Historial();
            historial.MenuVertical2.Width = PanelContraido ? 333 : 70;
            historial.Show();
        }

        public static void opciones()
        {
            var opciones = new Ajustes();
            opciones.MenuVertical2.Width = PanelContraido ? 333 : 70;
            opciones.Show();
        }

        public static void repararSistema()
        {
            var reparar = new RepararSistema();
            reparar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            reparar.Show();
        }

        public static void actualziarAplicaciones()
        {
            var actualizar = new ActualizarAplicacion();
            actualizar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            actualizar.Show();
        }

        public static void desfragmentarDisco()
        {
            var desfragmentar = new DesfragmentarDisco();
            desfragmentar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            desfragmentar.Show();
        }

        public static void limpiarSistema()
        {
            var limpiar = new LimpiarSistema();
            limpiar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            limpiar.Show();
        }

        public static void liberarEspacio()
        {
            var liberar = new LiberarEspacio();
            liberar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            liberar.Show();
        }

        public static void antivirus(Button btnAntivirus, DropDownMenu dropDownMenu1)
        {
            dropDownMenu1.Show(btnAntivirus, btnAntivirus.Width,0);
        }

        public static void instalarAplicaciones()
        {
            var instalar = new InstalarAplicaciones();
            instalar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            instalar.Show();
        }

        public static void menuPrincipal()
        {
            MenuPrincipal a = new MenuPrincipal(MenuPrincipal.username);
            a.MenuVertical2.Width = PanelContraido ? 333 : 70;
            a.Show();
        }

        public static void cambiarBtnAntivirus(Button btnAntivirus, Panel MenuVertical2,DropDownMenu dropDownMenu1)
        {
            dropDownMenu1.IsMainMenu = true;
            // Ajustar el ancho del botón según el ancho del panel
            btnAntivirus.Width = MenuVertical2.Width;
            btnAntivirus.Text = MenuVertical2.Width < 333 ? "" : "Antivirus";

            // Suscribirse al evento SizeChanged del panel para actualizar el ancho del botón
            MenuVertical2.SizeChanged += (sender, e) =>
            {
                btnAntivirus.Width = MenuVertical2.Width;
                btnAntivirus.Text = MenuVertical2.Width < 333 ? "" : "Antivirus";
            };
        }


    }
}
