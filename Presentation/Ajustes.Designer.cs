namespace Presentation
{
    partial class Ajustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajustes));
            BarraTitulo = new Panel();
            label4 = new Label();
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
            PanelContenedor = new Panel();
            label10 = new Label();
            checkedListBox1 = new CheckedListBox();
            label9 = new Label();
            cb_idioma = new ComboBox();
            label8 = new Label();
            cb_tema = new ComboBox();
            label1 = new Label();
            tb_contrasena = new TextBox();
            label5 = new Label();
            btn_eliminar = new Button();
            label7 = new Label();
            tb_name_usuario = new TextBox();
            label6 = new Label();
            tb_name_equipo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_guardar = new Button();
            btn_volver = new Button();
            panel2 = new Panel();
            btn_Historial = new Button();
            btnSide = new PictureBox();
            dropDownMenu1 = new DropDownMenu(components);
            emisoft = new ToolStripMenuItem();
            escaner_rapido = new ToolStripMenuItem();
            ddm_comando = new DropDownMenu(components);
            btn_comando_uno = new ToolStripMenuItem();
            btn_comando_dos = new ToolStripMenuItem();
            btn_comando_tres = new ToolStripMenuItem();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelContenedor.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSide).BeginInit();
            dropDownMenu1.SuspendLayout();
            ddm_comando.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(249, 37);
            label4.TabIndex = 23;
            label4.Text = "Clean And Build";
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
            btnRestaurar.Click += BtnRestaurar_Click;
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
            btnMinimizar.Click += BtnMinimizar_Click;
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
            btnMaximizar.Click += BtnMaximizar_Click;
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
            btnCerrar.Click += BtnCerrar_Click;
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
            panel1.TabIndex = 6;
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
            button1.TabIndex = 22;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnCerrar_Click;
            // 
            // textNameEquipo
            // 
            textNameEquipo.AutoSize = true;
            textNameEquipo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNameEquipo.ForeColor = SystemColors.ButtonFace;
            textNameEquipo.Location = new Point(116, 75);
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
            textName.Location = new Point(116, 22);
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
            btnOtros.Size = new Size(328, 60);
            btnOtros.TabIndex = 16;
            btnOtros.Text = "Otros...";
            btnOtros.TextAlign = ContentAlignment.MiddleRight;
            btnOtros.UseVisualStyleBackColor = true;
            btnOtros.Click += BtnOtros_Click;
            btnOtros.MouseDown += BtnOtros_MouseDown;
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
            btnInstalarAplicaciones.Click += BtnInstalarAplicaciones_Click;
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
            btnAntivirus.UseVisualStyleBackColor = true;
            btnAntivirus.Click += BtnAntivirus_Click;
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
            btnLiberarEspacio.Click += BtnLiberarEspacio_Click;
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
            btnLimpiarSistema.Click += BtnLimpiarSistema_Click;
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
            btnDesfragmentarDisco.Click += BtnDesfragmentarDisco_Click;
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
            btnActualizarAplicaciones.Click += BtnActualizarAplicaciones_Click;
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
            btnRepararSistema.Click += BtnRepararSistema_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Controls.Add(label10);
            PanelContenedor.Controls.Add(checkedListBox1);
            PanelContenedor.Controls.Add(label9);
            PanelContenedor.Controls.Add(cb_idioma);
            PanelContenedor.Controls.Add(label8);
            PanelContenedor.Controls.Add(cb_tema);
            PanelContenedor.Controls.Add(label1);
            PanelContenedor.Controls.Add(tb_contrasena);
            PanelContenedor.Controls.Add(label5);
            PanelContenedor.Controls.Add(btn_eliminar);
            PanelContenedor.Controls.Add(label7);
            PanelContenedor.Controls.Add(tb_name_usuario);
            PanelContenedor.Controls.Add(label6);
            PanelContenedor.Controls.Add(tb_name_equipo);
            PanelContenedor.Controls.Add(label3);
            PanelContenedor.Controls.Add(label2);
            PanelContenedor.Controls.Add(btn_guardar);
            PanelContenedor.Controls.Add(btn_volver);
            PanelContenedor.Controls.Add(panel2);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(333, 48);
            PanelContenedor.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(967, 764);
            PanelContenedor.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(715, 344);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 64;
            label10.Text = "Accesibilidad:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.BackColor = Color.FromArgb(49, 66, 82);
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Font = new Font("Microsoft Sans Serif", 12F);
            checkedListBox1.ForeColor = Color.White;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Texto Grande", "Alto Contraste" });
            checkedListBox1.Location = new Point(715, 374);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(194, 50);
            checkedListBox1.TabIndex = 63;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(715, 242);
            label9.Name = "label9";
            label9.Size = new Size(184, 25);
            label9.TabIndex = 62;
            label9.Text = "Seleccionar Idioma:";
            // 
            // cb_idioma
            // 
            cb_idioma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_idioma.Font = new Font("Microsoft Sans Serif", 12F);
            cb_idioma.FormattingEnabled = true;
            cb_idioma.Items.AddRange(new object[] { "Español", "Inglés", "Otros" });
            cb_idioma.Location = new Point(715, 283);
            cb_idioma.Name = "cb_idioma";
            cb_idioma.Size = new Size(197, 33);
            cb_idioma.TabIndex = 61;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(715, 123);
            label8.Name = "label8";
            label8.Size = new Size(208, 25);
            label8.TabIndex = 60;
            label8.Text = "Tema de la aplicacion:";
            // 
            // cb_tema
            // 
            cb_tema.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_tema.Font = new Font("Microsoft Sans Serif", 12F);
            cb_tema.FormattingEnabled = true;
            cb_tema.Items.AddRange(new object[] { "Defecto", "Morado", "Verde", "Verano", "Blanco" });
            cb_tema.Location = new Point(715, 164);
            cb_tema.Name = "cb_tema";
            cb_tema.Size = new Size(197, 33);
            cb_tema.TabIndex = 59;
            cb_tema.SelectedIndexChanged += cb_tema_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(350, 319);
            label1.Name = "label1";
            label1.Size = new Size(232, 21);
            label1.TabIndex = 58;
            label1.Text = "-------------------------------------";
            // 
            // tb_contrasena
            // 
            tb_contrasena.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_contrasena.BackColor = Color.FromArgb(49, 66, 82);
            tb_contrasena.BorderStyle = BorderStyle.None;
            tb_contrasena.Font = new Font("Century Gothic", 12F);
            tb_contrasena.ForeColor = SystemColors.InactiveBorder;
            tb_contrasena.Location = new Point(350, 300);
            tb_contrasena.Margin = new Padding(3, 4, 3, 4);
            tb_contrasena.Name = "tb_contrasena";
            tb_contrasena.Size = new Size(232, 25);
            tb_contrasena.TabIndex = 57;
            tb_contrasena.Text = "123";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(44, 300);
            label5.Name = "label5";
            label5.Size = new Size(222, 23);
            label5.TabIndex = 56;
            label5.Text = "Cambiar Contraseña:";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_eliminar.BackColor = Color.FromArgb(49, 66, 82);
            btn_eliminar.FlatAppearance.BorderColor = Color.Red;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(695, 659);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(217, 60);
            btn_eliminar.TabIndex = 55;
            btn_eliminar.Text = "Eliminar Usuario";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(350, 148);
            label7.Name = "label7";
            label7.Size = new Size(232, 21);
            label7.TabIndex = 54;
            label7.Text = "-------------------------------------";
            // 
            // tb_name_usuario
            // 
            tb_name_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_name_usuario.BackColor = Color.FromArgb(49, 66, 82);
            tb_name_usuario.BorderStyle = BorderStyle.None;
            tb_name_usuario.Font = new Font("Century Gothic", 12F);
            tb_name_usuario.ForeColor = SystemColors.InactiveBorder;
            tb_name_usuario.Location = new Point(350, 123);
            tb_name_usuario.Margin = new Padding(3, 4, 3, 4);
            tb_name_usuario.Name = "tb_name_usuario";
            tb_name_usuario.Size = new Size(232, 25);
            tb_name_usuario.TabIndex = 53;
            tb_name_usuario.Text = "Nombre";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(350, 248);
            label6.Name = "label6";
            label6.Size = new Size(232, 21);
            label6.TabIndex = 52;
            label6.Text = "-------------------------------------";
            // 
            // tb_name_equipo
            // 
            tb_name_equipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_name_equipo.BackColor = Color.FromArgb(49, 66, 82);
            tb_name_equipo.BorderStyle = BorderStyle.None;
            tb_name_equipo.Font = new Font("Century Gothic", 12F);
            tb_name_equipo.ForeColor = SystemColors.InactiveBorder;
            tb_name_equipo.Location = new Point(350, 229);
            tb_name_equipo.Margin = new Padding(3, 4, 3, 4);
            tb_name_equipo.Name = "tb_name_equipo";
            tb_name_equipo.Size = new Size(232, 25);
            tb_name_equipo.TabIndex = 51;
            tb_name_equipo.Text = "Equipo123";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(44, 229);
            label3.Name = "label3";
            label3.Size = new Size(294, 23);
            label3.TabIndex = 46;
            label3.Text = "Cambiar Nombre De Equipo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(44, 123);
            label2.Name = "label2";
            label2.Size = new Size(262, 23);
            label2.TabIndex = 45;
            label2.Text = "Cambiar Nombre Usuario:";
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_guardar.BackColor = Color.Teal;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_guardar.Location = new Point(321, 659);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(217, 60);
            btn_guardar.TabIndex = 44;
            btn_guardar.Text = "Guardar Cambios";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += Btn_guardar_Click;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.BackColor = Color.Orange;
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.ForeColor = Color.Black;
            btn_volver.ImageAlign = ContentAlignment.MiddleLeft;
            btn_volver.Location = new Point(29, 659);
            btn_volver.Margin = new Padding(3, 4, 3, 4);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(239, 60);
            btn_volver.TabIndex = 43;
            btn_volver.Text = "Volver Al Menu";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += Btn_volver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Historial);
            panel2.Controls.Add(btnSide);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 59);
            panel2.TabIndex = 1;
            // 
            // btn_Historial
            // 
            btn_Historial.FlatAppearance.BorderSize = 0;
            btn_Historial.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Historial.FlatStyle = FlatStyle.Flat;
            btn_Historial.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Historial.ForeColor = Color.White;
            btn_Historial.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Historial.Location = new Point(70, 8);
            btn_Historial.Margin = new Padding(3, 4, 3, 4);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(148, 42);
            btn_Historial.TabIndex = 55;
            btn_Historial.Text = "Historial";
            btn_Historial.UseVisualStyleBackColor = true;
            btn_Historial.Click += Btn_Historial_Click;
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
            btnSide.Click += BtnSide_Click;
            // 
            // dropDownMenu1
            // 
            dropDownMenu1.ImageScalingSize = new Size(20, 20);
            dropDownMenu1.IsMainMenu = false;
            dropDownMenu1.Items.AddRange(new ToolStripItem[] { emisoft, escaner_rapido });
            dropDownMenu1.MenuItemHeight = 25;
            dropDownMenu1.MenuItemTextColor = Color.DimGray;
            dropDownMenu1.Name = "dropDownMenu1";
            dropDownMenu1.PrimaryColor = Color.MediumSlateBlue;
            dropDownMenu1.Size = new Size(185, 52);
            // 
            // emisoft
            // 
            emisoft.Name = "emisoft";
            emisoft.Size = new Size(184, 24);
            emisoft.Text = "Emisoft";
            emisoft.Click += Emisoft_Click;
            // 
            // escaner_rapido
            // 
            escaner_rapido.Name = "escaner_rapido";
            escaner_rapido.Size = new Size(184, 24);
            escaner_rapido.Text = "Escaneo Rapido";
            escaner_rapido.Click += Escaner_rapido_Click;
            // 
            // ddm_comando
            // 
            ddm_comando.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddm_comando.ImageScalingSize = new Size(20, 20);
            ddm_comando.IsMainMenu = false;
            ddm_comando.Items.AddRange(new ToolStripItem[] { btn_comando_uno, btn_comando_dos, btn_comando_tres });
            ddm_comando.MenuItemHeight = 25;
            ddm_comando.MenuItemTextColor = Color.DimGray;
            ddm_comando.Name = "ddm_comando";
            ddm_comando.PrimaryColor = Color.MediumSlateBlue;
            ddm_comando.Size = new Size(180, 82);
            // 
            // btn_comando_uno
            // 
            btn_comando_uno.Name = "btn_comando_uno";
            btn_comando_uno.Size = new Size(179, 26);
            btn_comando_uno.Text = "Comando 1";
            // 
            // btn_comando_dos
            // 
            btn_comando_dos.Name = "btn_comando_dos";
            btn_comando_dos.Size = new Size(179, 26);
            btn_comando_dos.Text = "Comando 2";
            // 
            // btn_comando_tres
            // 
            btn_comando_tres.Name = "btn_comando_tres";
            btn_comando_tres.Size = new Size(179, 26);
            btn_comando_tres.Text = "Comando 3";
            // 
            // Ajustes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 812);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ajustes";
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
            PanelContenedor.ResumeLayout(false);
            PanelContenedor.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSide).EndInit();
            dropDownMenu1.ResumeLayout(false);
            ddm_comando.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_name_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name_equipo;
        private Label label4;
        private Button button1;
        private Button btn_Historial;
        private Button btn_eliminar;
        private Panel panel9;
        private Panel panel1;
        private DropDownMenu dropDownMenu1;
        private ToolStripMenuItem emisoft;
        private ToolStripMenuItem escaner_rapido;
        private Label label9;
        private ComboBox cb_idioma;
        private Label label8;
        private ComboBox cb_tema;
        private Label label1;
        private TextBox tb_contrasena;
        private Label label5;
        private Label label10;
        private CheckedListBox checkedListBox1;
        private DropDownMenu ddm_comando;
        private ToolStripMenuItem btn_comando_uno;
        private ToolStripMenuItem btn_comando_dos;
        private ToolStripMenuItem btn_comando_tres;
    }
}

