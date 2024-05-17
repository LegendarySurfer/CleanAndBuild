namespace Presentation
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            linkpass = new LinkLabel();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            lblErrorMessage = new Label();
            label3 = new Label();
            imagen_help = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagen_help).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 412);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-60, -31);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(362, 465);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(15, 15, 15);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.InactiveBorder;
            username.Location = new Point(308, 79);
            username.Margin = new Padding(3, 4, 3, 4);
            username.Name = "username";
            username.Size = new Size(409, 25);
            username.TabIndex = 1;
            username.Text = "USERNAME";
            username.Enter += Username_Enter;
            username.Leave += Username_Leave;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(15, 15, 15);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.InactiveBorder;
            password.Location = new Point(308, 181);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(409, 25);
            password.TabIndex = 2;
            password.Text = "PASSWORD";
            password.Enter += Password_Enter;
            password.Leave += Password_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(305, 212);
            label1.Name = "label1";
            label1.Size = new Size(337, 20);
            label1.TabIndex = 3;
            label1.Text = "─────────────────────────────────────────";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(441, 11);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(40, 40, 40);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.LightGray;
            btn_login.Location = new Point(308, 290);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(373, 50);
            btn_login.TabIndex = 3;
            btn_login.Text = "ACCEDER";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += Btn_login_Click;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.LinkColor = Color.DimGray;
            linkpass.Location = new Point(364, 355);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(262, 21);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "¿Has olvidado la contraseña?";
            linkpass.LinkClicked += Linkpass_LinkClicked;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(738, 11);
            btn_cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(30, 38);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 9;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(702, 11);
            btn_minimizar.Margin = new Padding(3, 4, 3, 4);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 38);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 10;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Transparent;
            lblErrorMessage.Image = (Image)resources.GetObject("lblErrorMessage.Image");
            lblErrorMessage.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMessage.Location = new Point(308, 252);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(131, 21);
            lblErrorMessage.TabIndex = 11;
            lblErrorMessage.Text = "Error Message";
            lblErrorMessage.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(308, 108);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 12;
            label3.Text = "─────────────────────────────────────────";
            // 
            // imagen_help
            // 
            imagen_help.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imagen_help.Image = (Image)resources.GetObject("imagen_help.Image");
            imagen_help.Location = new Point(253, 11);
            imagen_help.Margin = new Padding(3, 4, 3, 4);
            imagen_help.Name = "imagen_help";
            imagen_help.Size = new Size(49, 46);
            imagen_help.SizeMode = PictureBoxSizeMode.Zoom;
            imagen_help.TabIndex = 23;
            imagen_help.TabStop = false;
            imagen_help.Click += Imagen_help_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 412);
            Controls.Add(imagen_help);
            Controls.Add(label3);
            Controls.Add(lblErrorMessage);
            Controls.Add(btn_minimizar);
            Controls.Add(btn_cerrar);
            Controls.Add(linkpass);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagen_help).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblErrorMessage;
        private Label label3;
        private PictureBox imagen_help;
    }
}

