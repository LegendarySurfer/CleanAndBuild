namespace Presentation
{
    partial class Antivirus
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antivirus));
            BarraTitulo = new Panel();
            label1 = new Label();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel9 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            textNameEquipo = new Label();
            textName = new Label();
            btnOtros = new Button();
            panel8 = new Panel();
            btnInstalarAplicaciones = new Button();
            panel7 = new Panel();
            btnAntivirus = new Button();
            panel6 = new Panel();
            btnLiberarEspacio = new Button();
            panel5 = new Panel();
            btnLimpiarSistema = new Button();
            panel4 = new Panel();
            btnDesfragmentarDisco = new Button();
            panel3 = new Panel();
            btnActualizarAplicaciones = new Button();
            pictureBox2 = new PictureBox();
            btnRepararSistema = new Button();
            btnSide = new PictureBox();
            PanelContenedor = new Panel();
            imagen_help = new PictureBox();
            button2 = new Button();
            btn_escaner_rapido = new Button();
            btn_volver = new Button();
            panel2 = new Panel();
            btn_opciones = new Button();
            btn_Historial = new Button();
            userModelBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSide).BeginInit();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_help).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(label1);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 48);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 22;
            label1.Text = "Clean And Build";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1220, 9);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 31);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1176, 9);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 31);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1220, 9);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 31);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1263, 9);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 31);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(panel9);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(textNameEquipo);
            MenuVertical.Controls.Add(textName);
            MenuVertical.Controls.Add(btnOtros);
            MenuVertical.Controls.Add(panel8);
            MenuVertical.Controls.Add(btnInstalarAplicaciones);
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(btnAntivirus);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btnLiberarEspacio);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btnLimpiarSistema);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnDesfragmentarDisco);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnActualizarAplicaciones);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(btnRepararSistema);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 48);
            MenuVertical.Margin = new Padding(3, 4, 3, 4);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(333, 764);
            MenuVertical.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 80, 200);
            panel9.Location = new Point(0, 644);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(5, 60);
            panel9.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 160);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 60);
            panel1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 708);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(333, 56);
            button1.TabIndex = 21;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCerrar_Click;
            // 
            // textNameEquipo
            // 
            textNameEquipo.AutoSize = true;
            textNameEquipo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNameEquipo.ForeColor = SystemColors.ButtonFace;
            textNameEquipo.Location = new Point(99, 67);
            textNameEquipo.Name = "textNameEquipo";
            textNameEquipo.Size = new Size(139, 21);
            textNameEquipo.TabIndex = 19;
            textNameEquipo.Text = "Nombre Equipo";
            // 
            // textName
            // 
            textName.AutoSize = true;
            textName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.ForeColor = SystemColors.ButtonFace;
            textName.Location = new Point(99, 24);
            textName.Name = "textName";
            textName.Size = new Size(142, 21);
            textName.TabIndex = 18;
            textName.Text = "Nombre Usuario";
            // 
            // btnOtros
            // 
            btnOtros.FlatAppearance.BorderSize = 0;
            btnOtros.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnOtros.FlatStyle = FlatStyle.Flat;
            btnOtros.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOtros.ForeColor = Color.White;
            btnOtros.Image = (Image)resources.GetObject("btnOtros.Image");
            btnOtros.ImageAlign = ContentAlignment.MiddleLeft;
            btnOtros.Location = new Point(3, 644);
            btnOtros.Margin = new Padding(3, 4, 3, 4);
            btnOtros.Name = "btnOtros";
            btnOtros.Size = new Size(328, 42);
            btnOtros.TabIndex = 16;
            btnOtros.Text = "Otros...";
            btnOtros.UseVisualStyleBackColor = true;
            btnOtros.Click += btnOtros_Click;
            btnOtros.MouseDown += btnOtros_MouseDown;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 570);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 60);
            panel8.TabIndex = 15;
            // 
            // btnInstalarAplicaciones
            // 
            btnInstalarAplicaciones.FlatAppearance.BorderSize = 0;
            btnInstalarAplicaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnInstalarAplicaciones.FlatStyle = FlatStyle.Flat;
            btnInstalarAplicaciones.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInstalarAplicaciones.ForeColor = Color.White;
            btnInstalarAplicaciones.Image = (Image)resources.GetObject("btnInstalarAplicaciones.Image");
            btnInstalarAplicaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnInstalarAplicaciones.Location = new Point(3, 570);
            btnInstalarAplicaciones.Margin = new Padding(3, 4, 3, 4);
            btnInstalarAplicaciones.Name = "btnInstalarAplicaciones";
            btnInstalarAplicaciones.Size = new Size(328, 60);
            btnInstalarAplicaciones.TabIndex = 14;
            btnInstalarAplicaciones.Text = "Instalar Aplicaciones";
            btnInstalarAplicaciones.TextAlign = ContentAlignment.MiddleRight;
            btnInstalarAplicaciones.UseVisualStyleBackColor = true;
            btnInstalarAplicaciones.Click += btnInstalarAplicaciones_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(0, 502);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 60);
            panel7.TabIndex = 13;
            // 
            // btnAntivirus
            // 
            btnAntivirus.BackColor = Color.DeepSkyBlue;
            btnAntivirus.FlatAppearance.BorderSize = 0;
            btnAntivirus.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAntivirus.FlatStyle = FlatStyle.Flat;
            btnAntivirus.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAntivirus.ForeColor = Color.White;
            btnAntivirus.Image = (Image)resources.GetObject("btnAntivirus.Image");
            btnAntivirus.ImageAlign = ContentAlignment.MiddleLeft;
            btnAntivirus.Location = new Point(3, 502);
            btnAntivirus.Margin = new Padding(3, 4, 3, 4);
            btnAntivirus.Name = "btnAntivirus";
            btnAntivirus.Size = new Size(328, 60);
            btnAntivirus.TabIndex = 12;
            btnAntivirus.Text = "Antivirus";
            btnAntivirus.TextAlign = ContentAlignment.MiddleRight;
            btnAntivirus.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 435);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 60);
            panel6.TabIndex = 11;
            // 
            // btnLiberarEspacio
            // 
            btnLiberarEspacio.FlatAppearance.BorderSize = 0;
            btnLiberarEspacio.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnLiberarEspacio.FlatStyle = FlatStyle.Flat;
            btnLiberarEspacio.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLiberarEspacio.ForeColor = Color.White;
            btnLiberarEspacio.Image = (Image)resources.GetObject("btnLiberarEspacio.Image");
            btnLiberarEspacio.ImageAlign = ContentAlignment.MiddleLeft;
            btnLiberarEspacio.Location = new Point(3, 435);
            btnLiberarEspacio.Margin = new Padding(3, 4, 3, 4);
            btnLiberarEspacio.Name = "btnLiberarEspacio";
            btnLiberarEspacio.Size = new Size(328, 60);
            btnLiberarEspacio.TabIndex = 10;
            btnLiberarEspacio.Text = "Liberar Espacio Disco";
            btnLiberarEspacio.TextAlign = ContentAlignment.MiddleRight;
            btnLiberarEspacio.UseVisualStyleBackColor = true;
            btnLiberarEspacio.Click += btnLiberarEspacio_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 368);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 60);
            panel5.TabIndex = 9;
            // 
            // btnLimpiarSistema
            // 
            btnLimpiarSistema.FlatAppearance.BorderSize = 0;
            btnLimpiarSistema.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnLimpiarSistema.FlatStyle = FlatStyle.Flat;
            btnLimpiarSistema.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiarSistema.ForeColor = Color.White;
            btnLimpiarSistema.Image = (Image)resources.GetObject("btnLimpiarSistema.Image");
            btnLimpiarSistema.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarSistema.Location = new Point(3, 368);
            btnLimpiarSistema.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarSistema.Name = "btnLimpiarSistema";
            btnLimpiarSistema.Size = new Size(328, 60);
            btnLimpiarSistema.TabIndex = 8;
            btnLimpiarSistema.Text = "Limpiar Sistema";
            btnLimpiarSistema.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarSistema.UseVisualStyleBackColor = true;
            btnLimpiarSistema.Click += btnLimpiarSistema_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 300);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 60);
            panel4.TabIndex = 7;
            // 
            // btnDesfragmentarDisco
            // 
            btnDesfragmentarDisco.FlatAppearance.BorderSize = 0;
            btnDesfragmentarDisco.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnDesfragmentarDisco.FlatStyle = FlatStyle.Flat;
            btnDesfragmentarDisco.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesfragmentarDisco.ForeColor = Color.White;
            btnDesfragmentarDisco.Image = (Image)resources.GetObject("btnDesfragmentarDisco.Image");
            btnDesfragmentarDisco.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesfragmentarDisco.Location = new Point(3, 300);
            btnDesfragmentarDisco.Margin = new Padding(3, 4, 3, 4);
            btnDesfragmentarDisco.Name = "btnDesfragmentarDisco";
            btnDesfragmentarDisco.Size = new Size(328, 60);
            btnDesfragmentarDisco.TabIndex = 6;
            btnDesfragmentarDisco.Text = "Desfragmentar Disco";
            btnDesfragmentarDisco.TextAlign = ContentAlignment.MiddleRight;
            btnDesfragmentarDisco.UseVisualStyleBackColor = true;
            btnDesfragmentarDisco.Click += btnDesfragmentarDisco_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 228);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 60);
            panel3.TabIndex = 5;
            // 
            // btnActualizarAplicaciones
            // 
            btnActualizarAplicaciones.FlatAppearance.BorderSize = 0;
            btnActualizarAplicaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnActualizarAplicaciones.FlatStyle = FlatStyle.Flat;
            btnActualizarAplicaciones.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarAplicaciones.ForeColor = Color.White;
            btnActualizarAplicaciones.Image = (Image)resources.GetObject("btnActualizarAplicaciones.Image");
            btnActualizarAplicaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarAplicaciones.Location = new Point(3, 228);
            btnActualizarAplicaciones.Margin = new Padding(3, 4, 3, 4);
            btnActualizarAplicaciones.Name = "btnActualizarAplicaciones";
            btnActualizarAplicaciones.Size = new Size(328, 60);
            btnActualizarAplicaciones.TabIndex = 4;
            btnActualizarAplicaciones.Text = "Actualizar Aplicaciones";
            btnActualizarAplicaciones.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarAplicaciones.UseVisualStyleBackColor = true;
            btnActualizarAplicaciones.Click += btnActualizarAplicaciones_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnRepararSistema
            // 
            btnRepararSistema.FlatAppearance.BorderSize = 0;
            btnRepararSistema.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRepararSistema.FlatStyle = FlatStyle.Flat;
            btnRepararSistema.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRepararSistema.ForeColor = Color.White;
            btnRepararSistema.Image = (Image)resources.GetObject("btnRepararSistema.Image");
            btnRepararSistema.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepararSistema.Location = new Point(3, 160);
            btnRepararSistema.Margin = new Padding(3, 4, 3, 4);
            btnRepararSistema.Name = "btnRepararSistema";
            btnRepararSistema.Size = new Size(325, 60);
            btnRepararSistema.TabIndex = 0;
            btnRepararSistema.Text = "Reparar Sistema";
            btnRepararSistema.TextAlign = ContentAlignment.MiddleRight;
            btnRepararSistema.UseVisualStyleBackColor = true;
            btnRepararSistema.Click += btnRepararSistema_Click;
            // 
            // btnSide
            // 
            btnSide.Cursor = Cursors.Hand;
            btnSide.Image = (Image)resources.GetObject("btnSide.Image");
            btnSide.Location = new Point(0, 0);
            btnSide.Margin = new Padding(3, 4, 3, 4);
            btnSide.Name = "btnSide";
            btnSide.Size = new Size(64, 62);
            btnSide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSide.TabIndex = 0;
            btnSide.TabStop = false;
            btnSide.Click += btnSide_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Controls.Add(pictureBox1);
            PanelContenedor.Controls.Add(imagen_help);
            PanelContenedor.Controls.Add(button2);
            PanelContenedor.Controls.Add(btn_escaner_rapido);
            PanelContenedor.Controls.Add(btn_volver);
            PanelContenedor.Controls.Add(panel2);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(333, 48);
            PanelContenedor.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(967, 764);
            PanelContenedor.TabIndex = 2;
            // 
            // imagen_help
            // 
            imagen_help.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imagen_help.Image = (Image)resources.GetObject("imagen_help.Image");
            imagen_help.Location = new Point(906, 67);
            imagen_help.Margin = new Padding(3, 4, 3, 4);
            imagen_help.Name = "imagen_help";
            imagen_help.Size = new Size(49, 46);
            imagen_help.SizeMode = PictureBoxSizeMode.Zoom;
            imagen_help.TabIndex = 49;
            imagen_help.TabStop = false;
            imagen_help.MouseEnter += imagen_help_MouseEnter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(639, 644);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(239, 60);
            button2.TabIndex = 48;
            button2.Text = "Escaner Con Emisoft";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_escaner_rapido
            // 
            btn_escaner_rapido.Anchor = AnchorStyles.Bottom;
            btn_escaner_rapido.FlatAppearance.BorderSize = 0;
            btn_escaner_rapido.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_escaner_rapido.FlatStyle = FlatStyle.Flat;
            btn_escaner_rapido.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_escaner_rapido.ForeColor = Color.White;
            btn_escaner_rapido.ImageAlign = ContentAlignment.MiddleLeft;
            btn_escaner_rapido.Location = new Point(306, 644);
            btn_escaner_rapido.Margin = new Padding(3, 4, 3, 4);
            btn_escaner_rapido.Name = "btn_escaner_rapido";
            btn_escaner_rapido.Size = new Size(239, 60);
            btn_escaner_rapido.TabIndex = 47;
            btn_escaner_rapido.Text = "Escaneo Rapido";
            btn_escaner_rapido.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.ForeColor = Color.White;
            btn_volver.ImageAlign = ContentAlignment.MiddleLeft;
            btn_volver.Location = new Point(51, 644);
            btn_volver.Margin = new Padding(3, 4, 3, 4);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(239, 60);
            btn_volver.TabIndex = 45;
            btn_volver.Text = "Volver Al Menu";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_opciones);
            panel2.Controls.Add(btnSide);
            panel2.Controls.Add(btn_Historial);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 59);
            panel2.TabIndex = 1;
            // 
            // btn_opciones
            // 
            btn_opciones.FlatAppearance.BorderSize = 0;
            btn_opciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_opciones.FlatStyle = FlatStyle.Flat;
            btn_opciones.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_opciones.ForeColor = Color.White;
            btn_opciones.ImageAlign = ContentAlignment.MiddleLeft;
            btn_opciones.Location = new Point(238, 8);
            btn_opciones.Margin = new Padding(3, 4, 3, 4);
            btn_opciones.Name = "btn_opciones";
            btn_opciones.Size = new Size(160, 42);
            btn_opciones.TabIndex = 34;
            btn_opciones.Text = "Opciones";
            btn_opciones.UseVisualStyleBackColor = true;
            btn_opciones.Click += btn_opciones_Click;
            // 
            // btn_Historial
            // 
            btn_Historial.FlatAppearance.BorderSize = 0;
            btn_Historial.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Historial.FlatStyle = FlatStyle.Flat;
            btn_Historial.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Historial.ForeColor = Color.White;
            btn_Historial.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Historial.Location = new Point(84, 8);
            btn_Historial.Margin = new Padding(3, 4, 3, 4);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(148, 42);
            btn_Historial.TabIndex = 33;
            btn_Historial.Text = "Historial";
            btn_Historial.UseVisualStyleBackColor = true;
            btn_Historial.Click += btn_Historial_Click;
            // 
            // userModelBindingSource
            // 
            userModelBindingSource.DataSource = typeof(Domain.UserModel);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 209);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // Antivirus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 812);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Antivirus";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSide).EndInit();
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagen_help).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnRepararSistema;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnInstalarAplicaciones;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAntivirus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLiberarEspacio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLimpiarSistema;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDesfragmentarDisco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnActualizarAplicaciones;
        private System.Windows.Forms.Label textNameEquipo;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSide;
        private Button button1;
        private Label label1;
        private BindingSource userModelBindingSource;
        private Button btn_opciones;
        private Button btn_Historial;
        private Button btn_volver;
        private Button btn_escaner_rapido;
        private Button button2;
        private PictureBox imagen_help;
        private Panel panel9;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}

