using Domain;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class LiberarEspacio : Form
    {
        public Panel MenuVertical2;

        public LiberarEspacio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // ventana centrada

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

            btn_limpiar.BackColor = TemaColores.btn_guardar;
            btn_volver.BackColor = TemaColores.btn_volver;
        }
        //---------------------------------------------------- botones windows ----------------------------------------------------
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Ventana.Salir();
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
            MenuVertical = Ventana.SideBar(MenuVertical);
            btnAntivirus.Width = MenuVertical.Width;
            btnAntivirus.Text = btnAntivirus.Width < 333 ? "" : "Antivirus";
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

        private void BtnInstalarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.InstalarAplicaciones();
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

        //---------------------------------------------------- imagen help ----------------------------------------------------
        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Libera espacio en disco al eliminar archivos temporales, caché, " +
                            "y otros elementos innecesarios para mejorar el rendimiento del sistema.",
                           "Liberar Espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //---------------------------------------------------- logica boton ----------------------------------------------------
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            richi.Text = "";

            Process p = new Process();

            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\liberar_espacio.bat");
            p.StartInfo.FileName = pathToBatchFile;
            p.EnableRaisingEvents = true;

            // Evento para manejar cuando el proceso termine
            p.Exited += (s, args) =>
            {
                bool todoBien = p.ExitCode == 0;

                // Actualizar el RichTextBox según si todo fue bien o no
                richi.Invoke((MethodInvoker)delegate
                {
                    if (todoBien)
                    {
                        richi.AppendText("¡TUS APLICACIONES SE HAN INSTALADO TU!\n\n");
                        richi.AppendText("Esta opcion de Windows funciona como un asistente de limpieza para tu computadora. " +
                            "Empieza anunciando que va a liberar espacio de almacenamiento no utilizado. " +
                            "Luego, se encarga de buscar y eliminar archivos temporales y otros archivos que ya no necesitas. " +
                            "Después de la limpieza, verifica si todo salió bien y te informa sobre lo que se ha eliminado y " +
                            "cuánto espacio se ha liberado. Si algo sale mal durante el proceso, te lo hace saber. Finalmente, " +
                            "te da un momento para revisar la información antes de que desaparezca.");
                    }
                    else
                    {
                        richi.Text = "Algo ha ido mal...";
                    }
                });
            };

            // Iniciar el proceso
            p.Start();

            //guardamos en la BBDD
            UserModel userModel = new UserModel();
            userModel.GuardarComando("Liberar Espacio", "liberar_espacio");
            userModel.GuardarEnHistorial(MenuPrincipal.username);
        }
    }
}
