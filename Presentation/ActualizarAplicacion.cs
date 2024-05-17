using Domain;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class ActualizarAplicacion : Form
    {
        public Panel MenuVertical2;

        public ActualizarAplicacion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // centrar la ventana

            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo 
            MenuVertical2 = MenuVertical;

            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.CompuebaEstadoVentana();

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
            //logica para mostrar los botones que se creen
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


        //---------------------------------------------------- logica del boton ----------------------------------------------------
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            richi.Text = "";

            Process p = new Process();

            if (cb_comando.Checked)
            {
                MessageBox.Show("Espere un momento mientras se termina de actualizar todo.",
                "Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\update.bat");

                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c \"" + pathToBatchFile + "\"";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.EnableRaisingEvents = true;

                p.Exited += (s, args) =>
                {
                    bool todoBien = p.ExitCode == 0;
                    richi.Invoke((MethodInvoker)delegate
                    {
                        richi.AppendText(todoBien ? "¡TODO HA SALIDO PERFECTO!\n\n" : "Algo ha ido mal...\n\n");
                        richi.AppendText(p.StandardOutput.ReadToEnd());
                    });
                };

                p.Start();
            }

            if (cb_aplicaciones.Checked)
            {
                string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\winget.bat");
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
                            richi.AppendText("¡TUS APLICACIONES SE HAN INSTALADO!\n" +
                                "Este script ejecuta el comando Winget, es como un asistente que te ayuda a " +
                                "encontrar, instalar y mantener actualizadas todas las aplicaciones que usas en tu computadora con Windows. " +
                                "Imagina que tienes una biblioteca con muchos libros y necesitas encontrar uno nuevo. " +
                                "En lugar de buscar en diferentes librerías o tiendas, simplemente le dices a Winget qué libro quieres, " +
                                "y él se encarga de buscarlo y descargarlo para ti, asegurándose de que siempre tengas la versión más reciente. " +
                                "Además, si ya tienes algunos libros en tu biblioteca y hay nuevas ediciones disponibles, Winget también " +
                                "puede actualizarlos automáticamente para ti, manteniéndote al día con las últimas versiones.");

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

            if (!cb_aplicaciones.Checked && !cb_comando.Checked)
            {
                MessageBox.Show("Tiene que seleccionar una opcion.",
                    "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cb_comando.Checked = false;
            cb_aplicaciones.Checked = false;


        }

        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualiza con un script tus aplicaciones o comandos.",
                           "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
