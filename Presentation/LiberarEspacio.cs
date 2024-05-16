﻿using Domain;
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

        //imagen help
        private void imagen_help_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Libera espacio en disco al eliminar archivos temporales, caché, " +
                "y otros elementos innecesarios para mejorar el rendimiento del sistema.",
               "Limpiar sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\liberar_espacio.bat");
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c \"" + pathToBatchFile + "\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
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
                        richi.AppendText(p.StandardOutput.ReadToEnd());
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
