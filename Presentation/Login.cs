using System.Drawing.Drawing2D;
using DataAccess;
using Domain;

namespace Presentation
{
    public partial class Login : Form
    {
        // Tamaño del borde redondeado
        private const int BORDER_RADIUS = 25;

        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            // Establecer el estilo del borde del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            // Suscribirse al evento Paint del formulario
            this.Paint += Form1_Paint;
        }

        // Dibujar los bordes redondeados
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BORDER_RADIUS, BORDER_RADIUS, 180, 90);
                path.AddArc(this.Width - BORDER_RADIUS, 0, BORDER_RADIUS, BORDER_RADIUS, 270, 90);
                path.AddArc(this.Width - BORDER_RADIUS, this.Height - BORDER_RADIUS, BORDER_RADIUS, BORDER_RADIUS, 0, 90);
                path.AddArc(0, this.Height - BORDER_RADIUS, BORDER_RADIUS, BORDER_RADIUS, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }

        //texto de username
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }
        }

        //texto de username
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        //texto de password
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
                password.UseSystemPasswordChar = true;

            }
        }

        //texto de password
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "PASSWORD";
                password.ForeColor = Color.DimGray;
            }
        }

        //btn que hace que la ventana pueda minimizarse
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //boton para el login
        private void btn_login_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            if (username.Text == "USERNAME" && password.Text == "PASSWORD")
            {
                msgError("Introduce el usuario y contraseña.");
                return;
            }

            if (user.LoginUser(username.Text, password.Text))
            {
                if (!user.compruebaEquipo())
                {
                    user.addEquipo(username.Text);
                }
                accederMenu();
            }
            else
            {
                if (user.compruebaUser(username.Text))
                {
                    msgError("Ese nombre de usuario ya existe.");
                }
                else
                {
                    user.CreateUser(username.Text, password.Text);
                    if (!user.compruebaEquipo())
                    {
                        user.addEquipo(username.Text);
                    }
                    accederMenu();
                }
            }
        }

        private void accederMenu()
        {
            MenuPrincipal main = new MenuPrincipal(username.Text);
            main.Show();
            Hide();
        }

        //mensaje de error
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "        " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            password.Text = "PASSWORD";
            password.UseSystemPasswordChar = false;
            username.Text = "USERNAME";

            lblErrorMessage.Visible = false;
            this.Show();
        }

        //cambiar contraseña
        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContrasena cambiar = new CambiarContrasena();
            cambiar.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Para iniciar sesion con un usuario existente ponga solo las credenciales.\n" +
                "- Para iniciar sesion con usuario nuevo solo introduzca un nombre no existenten y una contraseña.",
               "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
