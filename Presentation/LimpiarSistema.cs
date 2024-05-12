using Domain;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class LimpiarSistema : Form
    {
        public Panel MenuVertical2;

        public LimpiarSistema()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // posicion de la ventana

            textName.Text = MenuPrincipal.username; // nombre usuario
            textNameEquipo.Text = MenuPrincipal.nombreEquipo; // nombre del equipo
            MenuVertical2 = MenuVertical;

            Ventana.cambiarBtnAntivirus(btnAntivirus, MenuVertical2, dropDownMenu1);
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
        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Ventana.historial();
            Close();
        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            Ventana.opciones();
            Close();
        }

        private void btnActualizarAplicaciones_Click(object sender, EventArgs e)
        {
            Ventana.actualziarAplicaciones();
            Close();
        }

        private void btnRepararSistema_Click(object sender, EventArgs e)
        {
            Ventana.repararSistema();
            Close();
        }

        private void btnDesfragmentarDisco_Click(object sender, EventArgs e)
        {
            Ventana.desfragmentarDisco();
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

        //imagen help
        private void imagen_help_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("Limpieza los archivos temporales y la papelera entre otros.",
               "Limpieza", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
