using Domain;
using System.Drawing.Drawing2D;

namespace Presentation
{
    public partial class CambiarContrasena : Form
    {

        // Tamaño del borde redondeado
        private const int BORDER_RADIUS = 25;

        public CambiarContrasena()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;//aparecer centrado
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

        //control de los botones
        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Close();
        }

        private void Btn_cambiar_contrasena_Click(object sender, EventArgs e)
        {
            //primero comprobamos que existe el usuario
            UserModel us = new UserModel();
            if (us.CompruebaUser(username.Text))
            {//el usuario existe
                us.CambiarContrasena(username.Text, password.Text);
                MessageBox.Show("La contraseña se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username.Text = "USERNAME";
                password.Text = "PASSWORD";
            }
            else
            {//el usuario no existe
                MensajeError("No existe el usuario");
            }

        }

        //msg error
        public void MensajeError(string error)
        {
            lblErrorMessage.Text = "        " + error;
            lblErrorMessage.Visible = true;
        }

        //control del texto
        private void Username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "NEW PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "NEW PASSWORD";
                password.ForeColor = Color.DimGray;
            }
        }
    }
}
