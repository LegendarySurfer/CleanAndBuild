using System.Runtime.InteropServices;
using System.Management;
using Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class Ajustes : Form
    {
        public Panel MenuVertical2;

        public Ajustes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            InfoUser();
            MenuVertical2 = MenuVertical;

            Ventana.CambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
            WindowState = Ventana.CompuebaEstadoVentana();
            cb_idioma.Text = "Español";
            CambiarColor();
        }

        //---------------------------------------------------- mostrar info del usuario ----------------------------------------------------
        public void InfoUser()
        {
            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo 
        }

        //---------------------------------------------------- LOGICA ----------------------------------------------------
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // cambiar nombre de usuario
            if (tb_name_usuario.Text != "Nombre")
            {
                UserModel usuario = new UserModel();
                if (!usuario.CompruebaUser(tb_name_usuario.Text))//si no existe se cambia
                {
                    usuario.CambiarNombre(MenuPrincipal.username, tb_name_usuario.Text);
                    MenuPrincipal.username = tb_name_usuario.Text;
                    InfoUser();
                    MessageBox.Show("El nombre de usuario se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            //cambiar nombre del equipo
            try
            {
                if (tb_name_equipo.Text != "Equipo123")
                {
                    // Crear un proceso para ejecutar un comando PowerShell
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
                    psi.FileName = "powershell.exe";

                    // El comando PowerShell para cambiar el nombre del equipo
                    psi.Arguments = $"Rename-Computer -NewName {tb_name_equipo.Text} -Force";

                    // Ocultar la ventana de la consola de PowerShell
                    psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                    // Iniciar el proceso
                    System.Diagnostics.Process.Start(psi);

                    MessageBox.Show("El nombre del equipo se ha cambiado correctamente, es necesario reiniciar el equipo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("Error al cambiar el nombre del equipo." + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //cambiar la contraseña
            if (tb_contrasena.Text != "123")
            {
                //primero comprobamos que existe el usuario
                UserModel us = new UserModel();
                us.CambiarContrasena(MenuPrincipal.username, tb_contrasena.Text);
                MessageBox.Show("La contraseña se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        //---------------------------------------------------- botones ventana ----------------------------------------------------
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

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (textName.Text.Equals("admin"))
            {
                MessageBox.Show("El admin no se borra.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    new UserModel().EliminarUsuario(textName.Text);
                    MessageBox.Show("Usuario eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_tema_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarColor();
        }
        private void CambiarColor()
        {
            TemaColores.ColorSeleccionado = cb_tema.Text;

            TemaColores.ElegirTema(TemaColores.ColorSeleccionado);

            BarraTitulo.BackColor = TemaColores.BarraTitulo;
            PanelContenedor.BackColor = TemaColores.PanelContenedor;
            MenuVertical.BackColor = TemaColores.MenuVertical;

            btn_eliminar.BackColor = TemaColores.btn_eliminar;
            btn_guardar.BackColor = TemaColores.btn_guardar;
            btn_volver.BackColor = TemaColores.btn_volver;

            //guardamos el color para las demas vistas
        }
    }
}
