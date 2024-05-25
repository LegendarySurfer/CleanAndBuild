using Domain;
using System.Runtime.InteropServices;
using System.Data;
using System.Windows.Forms;


namespace Presentation
{
    public partial class MenuPrincipal : Form
    {
        public static string username; // mostrar nombre de usuario
        public static string nombreEquipo = Environment.MachineName;
        public static UserModel usuario = new UserModel();
        public Panel MenuVertical2;


        public MenuPrincipal(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // centrar ventana
            username = name;
            InfoUser(name);

            MenuVertical2 = MenuVertical;

            ddm_comando.IsMainMenu = true;
            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, ddm);
            WindowState = Ventana.CompuebaEstadoVentana();
            CambiarTema();

        }

        private void CambiarTema()
        {
            TemaColores.ElegirTema(TemaColores.ColorSeleccionado);

            BarraTitulo.BackColor = TemaColores.BarraTitulo;
            PanelContenedor.BackColor = TemaColores.PanelContenedor;
            MenuVertical.BackColor = TemaColores.MenuVertical;
        }

        //---------------------------------------------------- mostrar informacion de usuario ----------------------------------------------------
        public void InfoUser(string name)
        {
            textName.Text = name; // nombre usuario
            textNameEquipo.Text = nombreEquipo; // nombre del equipo
        }


        //---------------------------------------------------- botones windows ----------------------------------------------------
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Ventana.Salir();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSide_Click(object sender, EventArgs e)
        {
            MenuVertical = Ventana.SideBar(MenuVertical);
        }


        //---------------------------------------------------- codigo para mover la ventana ----------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //---------------------------------------------------- Botones laterales ----------------------------------------------------
        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana
            Ventana.Historial();
            Close();

        }

        private void Btn_opciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.Opciones();
            Close();
        }

        private void BtnRepararSistema_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.RepararSistema();
            Close();
        }

        private void BtnActualizarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.ActualziarAplicaciones();
            Close();
        }

        private void BtnDesfragmentarDisco_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.DesfragmentarDisco();
            Close();
        }

        private void BtnLimpiarSistema_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState;

            Ventana.LimpiarSistema();
            Close();
        }

        private void BtnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.LiberarEspacio();
            Close();
        }

        private void BtnAntivirus_Click(object sender, EventArgs e)
        {
            Ventana.Antivirus(btnAntivirus, ddm);
        }

        private void Emisoft_Click(object sender, EventArgs e)
        {
            Ventana.Emisoft();
        }

        private void BtnInstalarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.InstalarAplicaciones();
            Close();
        }

        private void Escaneo_rapido_Click(object sender, EventArgs e)
        {
            Ventana.EscanerRapido();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            if (username == "admin")
            {
                Ventana.estadoAnterior = WindowState;
                new AgregarComando().Show();
                Close();
            }
            else
            {
                Ventana.MostrarComandosCreados(btnOtros, ddm_comando);

                if (sender is Button btnPresionado)
                {
                    string mensaje = btnPresionado.Tag?.ToString() switch
                    {
                        "Comando Uno" => "Mensaje para el botón Comando Uno.",
                        "Comando Dos" => "Mensaje para el botón Comando Dos.",
                        _ => "Mensaje para otros botones."
                    };

                }
            }
        }



        private void btn_comando_uno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este script repara problemas comunes del sistema operativo Windows.\n " +
                "Primero, escanea y repara archivos dañados del sistema. Luego, realiza una verificación" +
                " adicional y corrige problemas utilizando otra herramienta de reparación. Si ves un mensaje " +
                "sobre la necesidad de reiniciar, asegúrate de hacerlo para completar el proceso. ",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_comando_dos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este script repara problemas comunes del sistema operativo Windows.\n " +
               "Primero, escanea y repara archivos dañados del sistema. Luego, realiza una verificación" +
               " adicional y corrige problemas utilizando otra herramienta de reparación. Si ves un mensaje " +
               "sobre la necesidad de reiniciar, asegúrate de hacerlo para completar el proceso. ",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_comando_tres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este script repara problemas comunes del sistema operativo Windows.\n " +
               "Primero, escanea y repara archivos dañados del sistema. Luego, realiza una verificación" +
               " adicional y corrige problemas utilizando otra herramienta de reparación. Si ves un mensaje " +
               "sobre la necesidad de reiniciar, asegúrate de hacerlo para completar el proceso. ",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
