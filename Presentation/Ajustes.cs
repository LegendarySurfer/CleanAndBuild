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
            infoUser();
            MenuVertical2 = MenuVertical;

            Ventana.cambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);

        }

        //---------------------------------------------------- mostrar info del usuario ----------------------------------------------------
        public void infoUser()
        {
            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo 
        }

        //---------------------------------------------------- LOGICA ----------------------------------------------------
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (tb_name_usuario.Text != "Nombre") // cambiar nombre de usuario
            {
                UserModel usuario = new UserModel();
                if (!usuario.compruebaUser(tb_name_usuario.Text))//si no existe se cambia
                {
                    usuario.cambiarNombre(MenuPrincipal.username, tb_name_usuario.Text);
                    MenuPrincipal.username = tb_name_usuario.Text;
                    infoUser();
                    MessageBox.Show("El nombre de usuario se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

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
                // Manejar la excepción
                MessageBox.Show("Error al cambiar el nombre del equipo." + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //---------------------------------------------------- botones ventana ----------------------------------------------------
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
        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Ventana.historial();
            Close();

        }

        private void btnRepararSistema_Click(object sender, EventArgs e)
        {
            Ventana.repararSistema();
            Close();
        }

        private void btnActualizarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.actualziarAplicaciones();
            Close();
        }

        private void btnDesfragmentarDisco_Click(object sender, EventArgs e)
        {
            Ventana.desfragmentarDisco();
            Close();
        }

        private void btnLimpiarSistema_Click(object sender, EventArgs e)
        {
            Ventana.limpiarSistema();
            Close();
        }

        private void btnLiberarEspacio_Click(object sender, EventArgs e)
        {
            Ventana.liberarEspacio();
            Close();
        }

        private void btnAntivirus_Click(object sender, EventArgs e)
        {
            Ventana.antivirus(btnAntivirus, dropDownMenu1);
        }

        private void btnInstalarAplicaciones_Click(object sender, EventArgs e)
        {
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
                var addComand = new AgregarComando();
                addComand.Show();
                Close();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Ventana.menuPrincipal();
            Close();
        }
    }
}
