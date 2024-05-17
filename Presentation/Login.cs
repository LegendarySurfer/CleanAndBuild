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
        private void Username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }
        }

        //texto de username
        private void Username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        //texto de password
        private void Password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
                password.UseSystemPasswordChar = true;

            }
        }

        //texto de password
        private void Password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "PASSWORD";
                password.ForeColor = Color.DimGray;
            }
        }

        //btn que hace que la ventana pueda minimizarse
        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //boton para el login
        private void Btn_login_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            //si no se introduce una persona error y nada
            if (username.Text == "USERNAME" && password.Text == "PASSWORD")
            {
                MsgError("Introduce el usuario y contraseña.");
                return;
            }

            // si no existe usuario guardo la persona y el equipo actual
            if(!user.LoginUser(username.Text, password.Text))//comprobamos si no existe
            {
                //si existe un usuario con el mismo nombre no lo crea
                if (!user.CompruebaUser(username.Text))
                {
                    user.CreateUser(username.Text, password.Text); //creamos usuario
                    if (!user.CompruebaEquipo()) user.AddEquipo();//guardamos el equipo en equipo  si esta registrado
                    user.AddEquipoEnRegistra(username.Text);//como es la primera ve que entra se guarda si o si
                    AccederMenu(); //fin del metodo
                }
                else
                {
                    MsgError("Contraseña mal o usuario existente.");
                    return;
                }
            }

            //usuario ya registrado
            if (user.LoginUser(username.Text, password.Text))//comprobamos si existe
            {
                if (user.CompruebaEquipo())
                {//si existe el equipo no hay que agregarlo otra vex
                    AccederMenu();
                }
                else
                {//el equipo no esta registrado y hay que registrarlo
                    user.AddEquipo();
                    user.AddEquipoEnRegistra(username.Text);//como es la primera ve que entra se guarda si o si
                    AccederMenu();
                }
            }
        }

        private void AccederMenu()
        {
            MenuPrincipal main = new MenuPrincipal(username.Text);
            main.Show();
            Hide();
        }

        //mensaje de error
        private void MsgError(string msg)
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
        private void Linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContrasena cambiar = new CambiarContrasena();
            cambiar.Show();
            this.Hide();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Imagen_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Para iniciar sesion con un usuario existente ponga solo las credenciales.\n" +
                "- Para iniciar sesion con usuario nuevo solo introduzca un nombre no existenten y una contraseña.",
               "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
