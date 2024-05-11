using Domain;

namespace Presentation
{
    public partial class CambiarContrasena : Form
    {
        //main
        public CambiarContrasena()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//aparecer centrado

        }

        //control de los botones
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Close();
        }

        private void btn_cambiar_contrasena_Click(object sender, EventArgs e)
        {
            //primero comprobamos que existe el usuario
            UserModel us = new UserModel();
            if (us.compruebaUser(username.Text))
            {//el usuario existe
                us.CambiarContrasena(username.Text, password.Text);
                MessageBox.Show("La contraseña se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username.Text = "USERNAME";
                password.Text = "PASSWORD";
            }
            else
            {//el usuario no existe
                mensajeError("No existe el usuario");
            }

        }

        //msg error
        public void mensajeError(string error)
        {
            lblErrorMessage.Text = "        " + error;
            lblErrorMessage.Visible = true;
        }

        //control del texto
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "NEW PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "NEW PASSWORD";
                password.ForeColor = Color.DimGray;
            }
        }
    }
}
