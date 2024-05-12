using System.Runtime.InteropServices;
using Domain;
using System.Diagnostics;

namespace Presentation
{
    public partial class InstalarAplicaciones : Form
    {
        public Panel MenuVertical2;

        public InstalarAplicaciones()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo
            MenuVertical2 = MenuVertical;

            Ventana.cambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.compuebaEstadoVentana();

        }

        //---------------------------------------------------- botones windows ----------------------------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Ventana.salir();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            MenuVertical = Ventana.sideBar(MenuVertical);
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


        //---------------------------------------------------- logica para instalar todo ----------------------------------------------------
        private void btn_Instalar_Click(object sender, EventArgs e)
        {
            List<string> programasSeleccionados = new List<string>();

            // Agregar los nombres de los programas seleccionados a la lista
            UserModel aplicaciones = new UserModel();
            if (cb_google.Checked)
            {
                programasSeleccionados.Add("chrome");
                aplicaciones.guardarAplicacion("chrome", "WEB BROWSER");
                cb_google.Checked = false;
            }

            if (cb_firefox.Checked)
            {
                programasSeleccionados.Add("firefox");
                aplicaciones.guardarAplicacion("firefox", "WEB BROWSER");
                cb_firefox.Checked = false;

            }

            if (cb_opera.Checked)
            {
                programasSeleccionados.Add("opera");
                aplicaciones.guardarAplicacion("opera", "WEB BROWSER");
                cb_opera.Checked = false;

            }

            if (cb_zoom.Checked)
            {
                programasSeleccionados.Add("zoom");
                aplicaciones.guardarAplicacion("zoom", "MESSAGING");
                cb_zoom.Checked = false;

            }

            if (cb_discord.Checked)
            {
                programasSeleccionados.Add("discord");
                aplicaciones.guardarAplicacion("discord", "MESSAGING");

                cb_discord.Checked = false;

            }

            if (cb_skype.Checked)
            {
                programasSeleccionados.Add("skype");
                aplicaciones.guardarAplicacion("skype", "MESSAGING");

                cb_skype.Checked = false;

            }

            if (cb_putty.Checked)
            {
                programasSeleccionados.Add("putty");
                aplicaciones.guardarAplicacion("putty", "DEVELOPER TOOLS");

                cb_putty.Checked = false;

            }

            if (cb_Eclipse.Checked)
            {
                programasSeleccionados.Add("eclipse");
                aplicaciones.guardarAplicacion("eclipse", "DEVELOPER TOOLS");

                cb_Eclipse.Checked = false;

            }

            if (cb_vscode.Checked)
            {
                programasSeleccionados.Add("vscode");
                aplicaciones.guardarAplicacion("vscode", "DEVELOPER TOOLS");

                cb_vscode.Checked = false;

            }

            if (cb_winrar.Checked)
            {
                programasSeleccionados.Add("winrar");
                aplicaciones.guardarAplicacion("winrar", "COMPRESSION");

                cb_winrar.Checked = false;

            }

            if (cb_blender.Checked)
            {
                programasSeleccionados.Add("blender");
                aplicaciones.guardarAplicacion("blender", "IMAGING");

                cb_blender.Checked = false;

            }

            if (cb_gimp.Checked)
            {
                programasSeleccionados.Add("gimp");
                aplicaciones.guardarAplicacion("gimp", "IMAGING");

                cb_gimp.Checked = false;

            }

            if (cb_steam.Checked)
            {
                programasSeleccionados.Add("steam");
                aplicaciones.guardarAplicacion("steam", "OTHER");
                cb_steam.Checked = false;

            }

            if (cb_vlc.Checked)
            {
                programasSeleccionados.Add("vlc");
                aplicaciones.guardarAplicacion("vlc", "OTHER");
                cb_vlc.Checked = false;

            }


            // Construir la cadena de argumentos
            string argumentos = string.Join(" ", programasSeleccionados);

            string batFilePath = Path.Combine(Application.StartupPath, @"..\..\..\scripts\installAplication.bat");

            if (!File.Exists(batFilePath))
            {
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = batFilePath,
                Arguments = argumentos, // Pasar los programas seleccionados como argumentos
                Verb = "runas",
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }

        //---------------------------------------------------- botones laterales ----------------------------------------------------
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.menuPrincipal();
            Close();
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.historial();
            Close();

        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.opciones();
            Close();
        }

        private void btnRepararSistema_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.repararSistema();
            Close();
        }

        private void btnActualizarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.actualziarAplicaciones();
            Close();
        }

        private void btnDesfragmentarDisco_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.desfragmentarDisco();
            Close();
        }

        private void btnLimpiarSistema_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.limpiarSistema();
            Close();
        }

        private void btnAntivirus_Click(object sender, EventArgs e)
        {
            Ventana.antivirus(btnAntivirus, dropDownMenu1);
        }

        private void btnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.liberarEspacio();
            Close();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            //logica para mostrar los botones que se creen
        }

        private void btnOtros_MouseDown(object sender, MouseEventArgs e)
        {
            //antes se tendra que comprobar que el usuario sea admin, si no no deja
            if (MenuPrincipal.username.Equals("admin") && e.Button == MouseButtons.Right)
            {
                Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

                var addComand = new AgregarComando();
                addComand.Show();
                Close();
            }
        }

        //imagen help
        private void imagen_help_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos a instalar alguna aplicaciones,es necesario el acceso a internet.",
              "Instalar aplicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.menuPrincipal();
            Close();
        }
    }
}
