using Domain;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class RepararSistema : Form
    {
        public Panel MenuVertical2;

        public RepararSistema()
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

            btn_Guardar.BackColor = TemaColores.btn_guardar;
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
            btnAntivirus.Width = MenuVertical.Width;
            btnAntivirus.Text = btnAntivirus.Width < 333 ? "" : "Antivirus";
        }

        //----------------------------------------------------codigo para mover la ventana ----------------------------------------------------
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

        private void BtnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.LiberarEspacio();
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

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.MenuPrincipal();
            Close();
        }

        //---------------------------------------------------- imagen de help ----------------------------------------------------
        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este script repara problemas comunes del sistema operativo Windows.\n " +
                "Primero, escanea y repara archivos dañados del sistema. Luego, realiza una verificación" +
                " adicional y corrige problemas utilizando otra herramienta de reparación. Si ves un mensaje " +
                "sobre la necesidad de reiniciar, asegúrate de hacerlo para completar el proceso. ",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------- Logica para reparar el sistema ----------------------------------------------------
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            richi.Text = "";
            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\repair.bat");

            Process p = new Process();
            p.StartInfo.FileName = pathToBatchFile;
            p.EnableRaisingEvents = true; // Habilitar eventos para detectar cuando el proceso termine

            // Evento para manejar cuando el proceso termine
            p.Exited += (s, args) =>
            {
                bool todoBien = p.ExitCode == 0;

                // Actualizar el RichTextBox según si todo fue bien o no
                richi.Invoke((MethodInvoker)delegate
                {
                    if (todoBien)
                    {
                        richi.AppendText("¡TODO HA SALIDO PERFECTO!\n\n");
                        richi.AppendText("Esta opción se ha ejecutado con el comando sfc /scannow, que ejecuta el \"System File Checker\" (SFC).\n");
                        richi.AppendText("El SFC es una herramienta de diagnóstico de Windows que permite a los usuarios escanear y reparar archivos del sistema dañados.\n\n");

                        richi.AppendText("El comando DISM /Online /Cleanup-Image /RestoreHealth se utiliza para restaurar la integridad del sistema de archivos.\n");
                        richi.AppendText("DISM significa \"Deployment Image Servicing and Management\" y es útil cuando SFC no puede reparar algunos archivos de sistema o cuando hay problemas más profundos con la imagen de Windows.\n\n");

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
            userModel.GuardarComando("Reparar Sistema", "repair");
            userModel.GuardarEnHistorial(MenuPrincipal.username);
        }
    }
}
