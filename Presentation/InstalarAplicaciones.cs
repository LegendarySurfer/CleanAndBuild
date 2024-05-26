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

            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.CompuebaEstadoVentana();
            CambiarTema();
            ddm_comando.IsMainMenu = true;

        }

        private void CambiarTema()
        {
            TemaColores.ElegirTema(TemaColores.ColorSeleccionado);

            BarraTitulo.BackColor = TemaColores.BarraTitulo;
            PanelContenedor.BackColor = TemaColores.PanelContenedor;
            MenuVertical.BackColor = TemaColores.MenuVertical;

            btn_Instalar.BackColor = TemaColores.btn_guardar;
            btn_volver.BackColor = TemaColores.btn_volver;

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


        //---------------------------------------------------- logica para instalar todo ----------------------------------------------------
       
        //guardo individualmente en la bbdd la aplicacion
        private void Btn_Instalar_Click(object sender, EventArgs e)
        {
            List<string> programasSeleccionados = new List<string>();

            // Agregar los nombres de los programas seleccionados a la lista
            UserModel aplicaciones = new UserModel();
            if (cb_google.Checked)
            {
                programasSeleccionados.Add("chrome");
                aplicaciones.GuardarAplicacion("chrome", "WEB BROWSER");// creamos aplicacion
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en historial

                cb_google.Checked = false;
            }

            if (cb_firefox.Checked)
            {
                programasSeleccionados.Add("firefox");
                aplicaciones.GuardarAplicacion("firefox", "WEB BROWSER");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_firefox.Checked = false;

            }

            if (cb_opera.Checked)
            {
                programasSeleccionados.Add("opera");
                aplicaciones.GuardarAplicacion("opera", "WEB BROWSER");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_opera.Checked = false;

            }

            if (cb_zoom.Checked)
            {
                programasSeleccionados.Add("zoom");
                aplicaciones.GuardarAplicacion("zoom", "MESSAGING");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_zoom.Checked = false;

            }

            if (cb_discord.Checked)
            {
                programasSeleccionados.Add("discord");
                aplicaciones.GuardarAplicacion("discord", "MESSAGING");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_discord.Checked = false;

            }

            if (cb_skype.Checked)
            {
                programasSeleccionados.Add("skype");
                aplicaciones.GuardarAplicacion("skype", "MESSAGING");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_skype.Checked = false;

            }

            if (cb_putty.Checked)
            {
                programasSeleccionados.Add("putty");
                aplicaciones.GuardarAplicacion("putty", "DEVELOPER TOOLS");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_putty.Checked = false;

            }

            if (cb_Eclipse.Checked)
            {
                programasSeleccionados.Add("eclipse");
                aplicaciones.GuardarAplicacion("eclipse", "DEVELOPER TOOLS");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_Eclipse.Checked = false;

            }

            if (cb_vscode.Checked)
            {
                programasSeleccionados.Add("vscode");
                aplicaciones.GuardarAplicacion("vscode", "DEVELOPER TOOLS");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

                cb_vscode.Checked = false;

            }

            if (cb_winrar.Checked)
            {
                programasSeleccionados.Add("winrar");
                aplicaciones.GuardarAplicacion("winrar", "COMPRESSION");

                cb_winrar.Checked = false;
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

            }

            if (cb_blender.Checked)
            {
                programasSeleccionados.Add("blender");
                aplicaciones.GuardarAplicacion("blender", "IMAGING");
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan
                cb_blender.Checked = false;

            }

            if (cb_gimp.Checked)
            {
                programasSeleccionados.Add("gimp");
                aplicaciones.GuardarAplicacion("gimp", "IMAGING");
                cb_gimp.Checked = false;
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

            }

            if (cb_steam.Checked)
            {
                programasSeleccionados.Add("steam");
                aplicaciones.GuardarAplicacion("steam", "OTHER");
                cb_steam.Checked = false;
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

            }

            if (cb_vlc.Checked)
            {
                programasSeleccionados.Add("vlc");
                aplicaciones.GuardarAplicacion("vlc", "OTHER");
                cb_vlc.Checked = false;
                aplicaciones.GuardarAplicacionEnIstalan();//guardamos aplicacion en instalan

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

            //Guardar comandos
            aplicaciones.GuardarComando("Instalar aplicaciones", "installAplication"); // creo comando
            aplicaciones.GuardarEnHistorial(MenuPrincipal.username); //guardo comando en historial

        }

        //---------------------------------------------------- botones laterales ----------------------------------------------------
        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.MenuPrincipal();
            Close();
        }

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
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.LimpiarSistema();
            Close();
        }

        private void BtnAntivirus_Click(object sender, EventArgs e)
        {
            Ventana.Antivirus(btnAntivirus, dropDownMenu1);
        }

        private void Emisoft_Click(object sender, EventArgs e)
        {
            Ventana.Emisoft();
        }

        private void Escaner_rapido_Click(object sender, EventArgs e)
        {
            Ventana.EscanerRapido();
        }

        private void BtnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.LiberarEspacio();
            Close();
        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {
            if (MenuPrincipal.username == "admin")
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

        private void BtnOtros_MouseDown(object sender, MouseEventArgs e)
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

        private void Btn_volver_Click_1(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana
            Ventana.MenuPrincipal();
            Close();
        }

        //imagen help
        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es necesario una conexion a internet para poder descargar las aplicaciones.",
             "Instalar aplicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
