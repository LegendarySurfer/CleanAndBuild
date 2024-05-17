namespace Presentation
{
    partial class CambiarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContrasena));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            btn_volver = new Button();
            btn_cambiar_contrasena = new Button();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            username = new TextBox();
            lblErrorMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 23;
            label1.Text = "Clean And Build";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(117, 67);
            label2.Name = "label2";
            label2.Size = new Size(458, 40);
            label2.TabIndex = 24;
            label2.Text = "¿OLVIDO SU CONTRASEÑA?";
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(40, 40, 40);
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_volver.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.ForeColor = Color.LightGray;
            btn_volver.Location = new Point(12, 367);
            btn_volver.Margin = new Padding(3, 4, 3, 4);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(231, 50);
            btn_volver.TabIndex = 25;
            btn_volver.Text = "VOLVER";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += Btn_volver_Click;
            // 
            // btn_cambiar_contrasena
            // 
            btn_cambiar_contrasena.BackColor = Color.FromArgb(40, 40, 40);
            btn_cambiar_contrasena.FlatAppearance.BorderSize = 0;
            btn_cambiar_contrasena.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_cambiar_contrasena.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_cambiar_contrasena.FlatStyle = FlatStyle.Flat;
            btn_cambiar_contrasena.ForeColor = Color.LightGray;
            btn_cambiar_contrasena.Location = new Point(515, 367);
            btn_cambiar_contrasena.Margin = new Padding(3, 4, 3, 4);
            btn_cambiar_contrasena.Name = "btn_cambiar_contrasena";
            btn_cambiar_contrasena.Size = new Size(231, 50);
            btn_cambiar_contrasena.TabIndex = 26;
            btn_cambiar_contrasena.Text = "CAMBIAR CONTRASEÑA";
            btn_cambiar_contrasena.UseVisualStyleBackColor = false;
            btn_cambiar_contrasena.Click += Btn_cambiar_contrasena_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(163, 175);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 30;
            label3.Text = "─────────────────────────────────────────";
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(15, 15, 15);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.InactiveBorder;
            password.Location = new Point(166, 244);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(334, 25);
            password.TabIndex = 28;
            password.Text = "NEW PASSWORD";
            password.Enter += Password_Enter;
            password.Leave += Password_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(163, 273);
            label4.Name = "label4";
            label4.Size = new Size(337, 20);
            label4.TabIndex = 29;
            label4.Text = "─────────────────────────────────────────";
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(15, 15, 15);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.InactiveBorder;
            username.Location = new Point(166, 146);
            username.Margin = new Padding(3, 4, 3, 4);
            username.Name = "username";
            username.Size = new Size(334, 25);
            username.TabIndex = 31;
            username.Text = "USERNAME";
            username.Enter += Username_Enter;
            username.Leave += Username_Leave;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Transparent;
            lblErrorMessage.Image = (Image)resources.GetObject("lblErrorMessage.Image");
            lblErrorMessage.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMessage.Location = new Point(166, 322);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(131, 21);
            lblErrorMessage.TabIndex = 32;
            lblErrorMessage.Text = "Error Message";
            lblErrorMessage.Visible = false;
            // 
            // CambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorMessage);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(btn_cambiar_contrasena);
            Controls.Add(btn_volver);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CambiarContrasena";
            Text = "CambiarContrasena";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btn_volver;
        private Button btn_cambiar_contrasena;
        private Label label3;
        private TextBox password;
        private Label label4;
        private TextBox username;
        private Label lblErrorMessage;
    }
}