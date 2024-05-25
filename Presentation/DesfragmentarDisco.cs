using Domain;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class DesfragmentarDisco : Form
    {
        public Panel MenuVertical2;

        public DesfragmentarDisco()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Centrar ventana

            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo
            MenuVertical2 = MenuVertical;

            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.CompuebaEstadoVentana();
            CambiarTema();

        }

        private void CambiarTema()
        {
            TemaColores.ElegirTema(TemaColores.ColorSeleccionado);

            BarraTitulo.BackColor = TemaColores.BarraTitulo;
            PanelContenedor.BackColor = TemaColores.PanelContenedor;
            MenuVertical.BackColor = TemaColores.MenuVertical;

            btn_desfragmentar.BackColor = TemaColores.btn_guardar;
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

        private void BtnRepararSistema_Click(object sender, EventArgs e)
        {
            Ventana.estadoAnterior = WindowState; // guarda el estado de la ventana

            Ventana.RepararSistema();
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

        //---------------------------------------------------- imagen help ----------------------------------------------------
        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al desfragmentar el disco, ten en cuenta estas precauciones:\n " +
        "1. Realiza una copia de seguridad de tus archivos importantes antes de comenzar la desfragmentación.\n" +
        "2. Asegúrate de tener suficiente espacio libre en disco para el proceso de desfragmentación.\n" +
        "3. Evita interrumpir el proceso de desfragmentación apagando o reiniciando tu computadora.\n" +
        "4. Cierra todos los programas y procesos en segundo plano para una desfragmentación más eficiente.\n" +
        "5. Desfragmenta tus discos de manera regular como parte de un programa de mantenimiento preventivo.\n" +
        "Siguiendo estas precauciones, puedes desfragmentar tus discos de manera segura y eficiente.",
        "Desfragmentar Disco", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------- Logica boton ----------------------------------------------------
        private void Btn_desfragmentar_Click(object sender, EventArgs e)
        {
            richi.Text = "";
            Process p = new Process();

            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\desfragmentar.bat");
            p.StartInfo.FileName = pathToBatchFile;
            p.EnableRaisingEvents = true; // Habilitar eventos para detectar cuando el proceso termine
            p.StartInfo.Arguments = name_disc.Text;

            // Evento para manejar cuando el proceso termine
            p.Exited += (s, args) =>
            {
                bool todoBien = p.ExitCode == 0;

                // Actualizar el RichTextBox según si todo fue bien o no
                richi.Invoke((MethodInvoker)delegate
                {
                    if (todoBien)
                    {
                        richi.AppendText("La desfragmentación se ha completado con éxito.\n\n" +
                            "El script de lote realiza la desfragmentación del disco y devuelve un código de salida indicando " +
                            "si la operación fue exitosa o no.");

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
            userModel.GuardarComando("Desfragmentar Disco", "Desfragmentar");//nombre del fichero .bat
            userModel.GuardarEnHistorial(MenuPrincipal.username);
        }
    }
}
