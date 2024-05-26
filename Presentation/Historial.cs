using System.Runtime.InteropServices;
using Domain;
using System.Data;

namespace Presentation
{
    public partial class Historial : Form
    {
        public Panel MenuVertical2;

        public Historial()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo 
            MenuVertical2 = MenuVertical;

            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.CompuebaEstadoVentana();

            cb_historial.Select(0, 0);
            cb_historial.Text = "Aplicaciones";
            CargarDatos();
            CambiarTema();
            ddm_comando.IsMainMenu = true;


        }

        private void CambiarTema()
        {
            TemaColores.ElegirTema(TemaColores.ColorSeleccionado);

            BarraTitulo.BackColor = TemaColores.BarraTitulo;
            PanelContenedor.BackColor = TemaColores.PanelContenedor;
            MenuVertical.BackColor = TemaColores.MenuVertical;

            btn_exportar.BackColor = TemaColores.btn_guardar;
            btn_importar.BackColor = TemaColores.btn_guardar;
            btn_volver.BackColor = TemaColores.btn_volver;

        }

        //---------------------------------------------------- muestra las operaciones realizadas ----------------------------------------------------
        public void CargarDatos()
        {
            UserModel historial = new UserModel();

            if (cb_historial.Text == "Comandos")
            {
                DataSet datos = historial.ObtenerComandosEquipo(MenuPrincipal.username);
                dg_historial.DataSource = datos.Tables[0];
            }
            else
            {//obtener aplicaciones de la bbdd instalan

                DataSet datos = historial.ObtenerAplicacionesEquipo(MenuPrincipal.nombreEquipo);
                dg_historial.DataSource = datos.Tables[0]; // datos de todos los usuarios
            }
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            try
            {
                string origen = Path.Combine(Application.StartupPath, @"..\..\..\..\BBDD\cleandbuild.db");
                string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BBDD");
                string destino = Path.Combine(carpetaDestino, "archivo.db");

                // Si la carpeta de destino no existe, la creamos
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                File.Copy(origen, destino, true);
                MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para seleccionar el archivo
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccione el archivo para importar",
                Filter = "Todos los archivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                string destinationFilePath = Path.Combine(Application.StartupPath, @"..\..\..\..\BBDD\cleandbuild.db");

                try
                {
                    // Copiar el archivo al destino, sobrescribiendo si ya existe
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show("Archivo importado y sustituido con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejar errores si ocurre algún problema durante la copia del archivo
                    MessageBox.Show($"Error al copiar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //---------------------------------------------------- botones laterales ----------------------------------------------------
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
            Ventana.MenuPrincipal();
            Close();
        }

        private void Cb_historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
