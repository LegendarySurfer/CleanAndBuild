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

        private void btnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.liberarEspacio();
            Close();
        }

        private void btnAntivirus_Click(object sender, EventArgs e)
        {
            Ventana.antivirus(btnAntivirus, dropDownMenu1);
        }

        private void emisoft_Click(object sender, EventArgs e)
        {
            Ventana.emisoft();
        }

        private void escaner_rapido_Click(object sender, EventArgs e)
        {
            Ventana.escanerRapido();
        }

        private void btnInstalarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.instalarAplicaciones();
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.menuPrincipal();
            Close();
        }

        //---------------------------------------------------- imagen de help ----------------------------------------------------
        private void imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este script repara problemas comunes del sistema operativo Windows.\n " +
                "Primero, escanea y repara archivos dañados del sistema. Luego, realiza una verificación" +
                " adicional y corrige problemas utilizando otra herramienta de reparación. Si ves un mensaje " +
                "sobre la necesidad de reiniciar, asegúrate de hacerlo para completar el proceso. ",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------- Logica para reparar el sistema ----------------------------------------------------
        private void btn_Guardar_Click(object sender, EventArgs e)
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
        }


    }
}
