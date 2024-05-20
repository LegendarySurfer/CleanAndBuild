namespace Presentation
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            BarraTitulo = new Panel();
            label7 = new Label();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_salir = new PictureBox();
            PanelContenedor = new Panel();
            btn_cargar = new Button();
            dg_historial = new DataGridView();
            cb_historial = new ComboBox();
            button2 = new Button();
            btn_exportar = new Button();
            btn_volver = new Button();
            panel2 = new Panel();
            btn_opciones = new Button();
            btnSide = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            MenuVertical = new Panel();
            panel9 = new Panel();
            textNameEquipo = new Label();
            panel1 = new Panel();
            textName = new Label();
            btn_salir_img = new Button();
            pictureBox2 = new PictureBox();
            btnOtros = new Button();
            btnInstalarAplicaciones = new Button();
            btnAntivirus = new Button();
            btnLiberarEspacio = new Button();
            btnLimpiarSistema = new Button();
            btnDesfragmentarDisco = new Button();
            btnActualizarAplicaciones = new Button();
            btnRepararSistema = new Button();
            dropDownMenu1 = new DropDownMenu(components);
            emisoft = new ToolStripMenuItem();
            escaner_rapido = new ToolStripMenuItem();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_salir).BeginInit();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_historial).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSide).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            dropDownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(label7);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btn_minimizar);
            BarraTitulo.Controls.Add(btn_salir);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 48);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(6, 7);
            label7.Name = "label7";
            label7.Size = new Size(249, 37);
            label7.TabIndex = 24;
            label7.Text = "Clean And Build";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1218, 9);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 31);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 5;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += BtnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1218, 9);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 31);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 4;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += BtnMaximizar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1178, 9);
            btn_minimizar.Margin = new Padding(3, 4, 3, 4);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(25, 31);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 23;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += BtnMinimizar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
            btn_salir.Location = new Point(1265, 9);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(25, 31);
            btn_salir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_salir.TabIndex = 22;
            btn_salir.TabStop = false;
            btn_salir.Click += BtnCerrar_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Controls.Add(btn_cargar);
            PanelContenedor.Controls.Add(dg_historial);
            PanelContenedor.Controls.Add(cb_historial);
            PanelContenedor.Controls.Add(button2);
            PanelContenedor.Controls.Add(btn_exportar);
            PanelContenedor.Controls.Add(btn_volver);
            PanelContenedor.Controls.Add(panel2);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(333, 48);
            PanelContenedor.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(967, 764);
            PanelContenedor.TabIndex = 2;
            // 
            // btn_cargar
            // 
            btn_cargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cargar.BackColor = Color.Teal;
            btn_cargar.FlatAppearance.BorderSize = 0;
            btn_cargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_cargar.FlatStyle = FlatStyle.Flat;
            btn_cargar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cargar.ForeColor = Color.White;
            btn_cargar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cargar.Location = new Point(707, 85);
            btn_cargar.Margin = new Padding(3, 4, 3, 4);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(203, 60);
            btn_cargar.TabIndex = 48;
            btn_cargar.Text = "CARGAR";
            btn_cargar.UseVisualStyleBackColor = false;
            btn_cargar.Click += Btn_cargar_Click;
            // 
            // dg_historial
            // 
            dg_historial.AllowUserToOrderColumns = true;
            dg_historial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_historial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_historial.BackgroundColor = Color.FromArgb(45, 66, 91);
            dg_historial.BorderStyle = BorderStyle.None;
            dg_historial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg_historial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg_historial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_historial.ColumnHeadersHeight = 30;
            dg_historial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg_historial.EnableHeadersVisualStyles = false;
            dg_historial.GridColor = Color.SteelBlue;
            dg_historial.Location = new Point(66, 206);
            dg_historial.Name = "dg_historial";
            dg_historial.ReadOnly = true;
            dg_historial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dg_historial.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dg_historial.RowHeadersVisible = false;
            dg_historial.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dg_historial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dg_historial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_historial.Size = new Size(844, 424);
            dg_historial.TabIndex = 47;
            // 
            // cb_historial
            // 
            cb_historial.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_historial.FormattingEnabled = true;
            cb_historial.Items.AddRange(new object[] { "Aplicaciones", "Comandos" });
            cb_historial.Location = new Point(66, 103);
            cb_historial.Name = "cb_historial";
            cb_historial.RightToLeft = RightToLeft.No;
            cb_historial.Size = new Size(218, 31);
            cb_historial.TabIndex = 46;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(364, -353);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(239, 60);
            button2.TabIndex = 45;
            button2.Text = "Volver Al Menu";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_exportar
            // 
            btn_exportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_exportar.FlatAppearance.BorderSize = 0;
            btn_exportar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_exportar.FlatStyle = FlatStyle.Flat;
            btn_exportar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exportar.ForeColor = Color.White;
            btn_exportar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exportar.Location = new Point(667, 659);
            btn_exportar.Margin = new Padding(3, 4, 3, 4);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(203, 60);
            btn_exportar.TabIndex = 44;
            btn_exportar.Text = "Exportar";
            btn_exportar.UseVisualStyleBackColor = true;
            btn_exportar.Click += Btn_exportar_Click;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.ForeColor = Color.Black;
            btn_volver.ImageAlign = ContentAlignment.MiddleLeft;
            btn_volver.Location = new Point(45, 659);
            btn_volver.Margin = new Padding(3, 4, 3, 4);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(239, 60);
            btn_volver.TabIndex = 43;
            btn_volver.Text = "Volver Al Menu";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += Btn_volver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_opciones);
            panel2.Controls.Add(btnSide);
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
            btn_opciones.Location = new Point(70, 7);
            btn_opciones.Margin = new Padding(3, 4, 3, 4);
            btn_opciones.Name = "btn_opciones";
            btn_opciones.Size = new Size(160, 42);
            btn_opciones.TabIndex = 32;
            btn_opciones.Text = "Opciones";
            btn_opciones.UseVisualStyleBackColor = true;
            btn_opciones.Click += Btn_opciones_Click;
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
            btnSide.TabIndex = 1;
            btnSide.TabStop = false;
            btnSide.Click += BtnSide_Click;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 300);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 60);
            panel4.TabIndex = 7;
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
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 435);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 60);
            panel6.TabIndex = 11;
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 570);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 60);
            panel8.TabIndex = 15;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(panel9);
            MenuVertical.Controls.Add(textNameEquipo);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(textName);
            MenuVertical.Controls.Add(btn_salir_img);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(btnOtros);
            MenuVertical.Controls.Add(btnInstalarAplicaciones);
            MenuVertical.Controls.Add(btnAntivirus);
            MenuVertical.Controls.Add(btnLiberarEspacio);
            MenuVertical.Controls.Add(panel8);
            MenuVertical.Controls.Add(btnLimpiarSistema);
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(btnDesfragmentarDisco);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btnActualizarAplicaciones);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btnRepararSistema);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(panel3);
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
            panel9.TabIndex = 7;
            // 
            // textNameEquipo
            // 
            textNameEquipo.AutoSize = true;
            textNameEquipo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNameEquipo.ForeColor = SystemColors.ButtonFace;
            textNameEquipo.Location = new Point(98, 71);
            textNameEquipo.Name = "textNameEquipo";
            textNameEquipo.Size = new Size(139, 21);
            textNameEquipo.TabIndex = 22;
            textNameEquipo.Text = "Nombre Equipo";
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
            // textName
            // 
            textName.AutoSize = true;
            textName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.ForeColor = SystemColors.ButtonFace;
            textName.Location = new Point(98, 28);
            textName.Name = "textName";
            textName.Size = new Size(142, 21);
            textName.TabIndex = 21;
            textName.Text = "Nombre Usuario";
            // 
            // btn_salir_img
            // 
            btn_salir_img.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_salir_img.FlatAppearance.BorderSize = 0;
            btn_salir_img.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_salir_img.FlatStyle = FlatStyle.Flat;
            btn_salir_img.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir_img.ForeColor = Color.White;
            btn_salir_img.Image = (Image)resources.GetObject("btn_salir_img.Image");
            btn_salir_img.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir_img.Location = new Point(5, 708);
            btn_salir_img.Margin = new Padding(3, 4, 3, 4);
            btn_salir_img.Name = "btn_salir_img";
            btn_salir_img.Size = new Size(333, 56);
            btn_salir_img.TabIndex = 30;
            btn_salir_img.Text = "Log out";
            btn_salir_img.UseVisualStyleBackColor = true;
            btn_salir_img.Click += BtnCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
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
            btnOtros.Location = new Point(8, 644);
            btnOtros.Margin = new Padding(3, 4, 3, 4);
            btnOtros.Name = "btnOtros";
            btnOtros.Size = new Size(322, 60);
            btnOtros.TabIndex = 29;
            btnOtros.Text = "Otros...";
            btnOtros.TextAlign = ContentAlignment.MiddleRight;
            btnOtros.UseVisualStyleBackColor = true;
            btnOtros.Click += BtnOtros_Click;
            btnOtros.MouseDown += BtnOtros_MouseDown;
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
            btnInstalarAplicaciones.Location = new Point(8, 570);
            btnInstalarAplicaciones.Margin = new Padding(3, 4, 3, 4);
            btnInstalarAplicaciones.Name = "btnInstalarAplicaciones";
            btnInstalarAplicaciones.Size = new Size(325, 60);
            btnInstalarAplicaciones.TabIndex = 28;
            btnInstalarAplicaciones.Text = "Instalar Aplicaciones";
            btnInstalarAplicaciones.TextAlign = ContentAlignment.MiddleRight;
            btnInstalarAplicaciones.UseVisualStyleBackColor = true;
            btnInstalarAplicaciones.Click += BtnInstalarAplicaciones_Click;
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
            btnAntivirus.Location = new Point(8, 502);
            btnAntivirus.Margin = new Padding(3, 4, 3, 4);
            btnAntivirus.Name = "btnAntivirus";
            btnAntivirus.Size = new Size(325, 60);
            btnAntivirus.TabIndex = 27;
            btnAntivirus.Text = "Antivirus";
            btnAntivirus.TextAlign = ContentAlignment.MiddleRight;
            btnAntivirus.UseVisualStyleBackColor = true;
            btnAntivirus.Click += BtnAntivirus_Click;
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
            btnLiberarEspacio.Location = new Point(8, 435);
            btnLiberarEspacio.Margin = new Padding(3, 4, 3, 4);
            btnLiberarEspacio.Name = "btnLiberarEspacio";
            btnLiberarEspacio.Size = new Size(325, 60);
            btnLiberarEspacio.TabIndex = 26;
            btnLiberarEspacio.Text = "Liberar Espacio Disco";
            btnLiberarEspacio.TextAlign = ContentAlignment.MiddleRight;
            btnLiberarEspacio.UseVisualStyleBackColor = true;
            btnLiberarEspacio.Click += BtnLiberarEspacio_Click;
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
            btnLimpiarSistema.Location = new Point(8, 368);
            btnLimpiarSistema.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarSistema.Name = "btnLimpiarSistema";
            btnLimpiarSistema.Size = new Size(325, 60);
            btnLimpiarSistema.TabIndex = 25;
            btnLimpiarSistema.Text = "Limpiar Sistema";
            btnLimpiarSistema.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarSistema.UseVisualStyleBackColor = true;
            btnLimpiarSistema.Click += BtnLimpiarSistema_Click;
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
            btnDesfragmentarDisco.Location = new Point(8, 300);
            btnDesfragmentarDisco.Margin = new Padding(3, 4, 3, 4);
            btnDesfragmentarDisco.Name = "btnDesfragmentarDisco";
            btnDesfragmentarDisco.Size = new Size(325, 60);
            btnDesfragmentarDisco.TabIndex = 24;
            btnDesfragmentarDisco.Text = "Desfragmentar Disco";
            btnDesfragmentarDisco.TextAlign = ContentAlignment.MiddleRight;
            btnDesfragmentarDisco.UseVisualStyleBackColor = true;
            btnDesfragmentarDisco.Click += BtnDesfragmentarDisco_Click;
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
            btnActualizarAplicaciones.Location = new Point(8, 228);
            btnActualizarAplicaciones.Margin = new Padding(3, 4, 3, 4);
            btnActualizarAplicaciones.Name = "btnActualizarAplicaciones";
            btnActualizarAplicaciones.Size = new Size(325, 60);
            btnActualizarAplicaciones.TabIndex = 23;
            btnActualizarAplicaciones.Text = "Actualizar Aplicaciones";
            btnActualizarAplicaciones.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarAplicaciones.UseVisualStyleBackColor = true;
            btnActualizarAplicaciones.Click += BtnActualizarAplicaciones_Click;
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
            btnRepararSistema.Location = new Point(8, 160);
            btnRepararSistema.Margin = new Padding(3, 4, 3, 4);
            btnRepararSistema.Name = "btnRepararSistema";
            btnRepararSistema.Size = new Size(325, 60);
            btnRepararSistema.TabIndex = 22;
            btnRepararSistema.Text = "Reparar Sistema";
            btnRepararSistema.TextAlign = ContentAlignment.MiddleRight;
            btnRepararSistema.UseVisualStyleBackColor = true;
            btnRepararSistema.Click += BtnRepararSistema_Click;
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
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 812);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Historial";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_salir).EndInit();
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_historial).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSide).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            dropDownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_volver;
        private PictureBox btn_minimizar;
        private PictureBox btn_salir;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel MenuVertical;
        private Panel panel1;
        private Button btn_salir_img;
        private Button btnOtros;
        private Button btnInstalarAplicaciones;
        private Button btnAntivirus;
        private Button btnLiberarEspacio;
        private Button btnLimpiarSistema;
        private Button btnDesfragmentarDisco;
        private Button btnActualizarAplicaciones;
        private Button btnRepararSistema;
        private PictureBox btnSide;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private Label label7;
        private Button button2;
        private Button btn_opciones;
        private Label textNameEquipo;
        private Label textName;
        private PictureBox pictureBox2;
        private ComboBox cb_historial;
        private DataGridView dg_historial;
        private Button btn_cargar;
        private Panel panel9;
        private DropDownMenu dropDownMenu1;
        private ToolStripMenuItem emisoft;
        private ToolStripMenuItem escaner_rapido;
    }
}

