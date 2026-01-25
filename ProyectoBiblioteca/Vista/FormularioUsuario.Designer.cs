namespace ProyectoBiblioteca
{
    partial class FormularioUsuario
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.smiInsertar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiInsertarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txbApellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.msPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiInsertar,
            this.toolStripMenuItem1,
            this.menUsuarios,
            this.menLibros,
            this.menPrestamos});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msPrincipal.Size = new System.Drawing.Size(800, 72);
            this.msPrincipal.TabIndex = 2;
            this.msPrincipal.Text = "MenuStrip1";
            // 
            // smiInsertar
            // 
            this.smiInsertar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiInsertarEmpleado,
            this.nombreToolStripMenuItem,
            this.apellidoToolStripMenuItem});
            this.smiInsertar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.smiInsertar.Image = global::ProyectoBiblioteca.Properties.Resources.Person_Male_Skin_Type_3;
            this.smiInsertar.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.smiInsertar.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.smiInsertar.Name = "smiInsertar";
            this.smiInsertar.Size = new System.Drawing.Size(240, 68);
            this.smiInsertar.Text = "Ayuntamiento Vitoria Gasteiz";
            this.smiInsertar.Click += new System.EventHandler(this.smiInsertar_Click);
            // 
            // smiInsertarEmpleado
            // 
            this.smiInsertarEmpleado.Name = "smiInsertarEmpleado";
            this.smiInsertarEmpleado.Size = new System.Drawing.Size(148, 26);
            this.smiInsertarEmpleado.Text = "Usuarios";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.nombreToolStripMenuItem.Text = "nombre";
            // 
            // apellidoToolStripMenuItem
            // 
            this.apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            this.apellidoToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.apellidoToolStripMenuItem.Text = "apellido";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 68);
            // 
            // menUsuarios
            // 
            this.menUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menUsuarios.Image = global::ProyectoBiblioteca.Properties.Resources.Add_User_Male1;
            this.menUsuarios.Margin = new System.Windows.Forms.Padding(45, 10, 10, 10);
            this.menUsuarios.Name = "menUsuarios";
            this.menUsuarios.Size = new System.Drawing.Size(108, 48);
            this.menUsuarios.Text = "Usuarios";
            this.menUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menLibros
            // 
            this.menLibros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menLibros.Image = global::ProyectoBiblioteca.Properties.Resources.Add_Book;
            this.menLibros.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menLibros.Margin = new System.Windows.Forms.Padding(15);
            this.menLibros.Name = "menLibros";
            this.menLibros.Padding = new System.Windows.Forms.Padding(5);
            this.menLibros.Size = new System.Drawing.Size(94, 38);
            this.menLibros.Text = "Libros ";
            // 
            // menPrestamos
            // 
            this.menPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menPrestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menPrestamos.Image = global::ProyectoBiblioteca.Properties.Resources.Books;
            this.menPrestamos.Margin = new System.Windows.Forms.Padding(15);
            this.menPrestamos.Name = "menPrestamos";
            this.menPrestamos.Size = new System.Drawing.Size(121, 38);
            this.menPrestamos.Text = "Prestamos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.89551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.03098F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 378);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.58923F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.41077F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbBuscarUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btBuscar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Usuario : ";
            // 
            // txbBuscarUsuario
            // 
            this.txbBuscarUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.txbBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBuscarUsuario.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbBuscarUsuario.Location = new System.Drawing.Point(117, 20);
            this.txbBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.txbBuscarUsuario.Name = "txbBuscarUsuario";
            this.txbBuscarUsuario.Size = new System.Drawing.Size(433, 15);
            this.txbBuscarUsuario.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBuscar.Location = new System.Drawing.Point(568, 15);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(15);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(211, 25);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Search";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.btEliminar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btEditar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btAgregar, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 76);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Location = new System.Drawing.Point(531, 3);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(260, 70);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditar.Location = new System.Drawing.Point(267, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(258, 70);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregar.Location = new System.Drawing.Point(3, 3);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(258, 70);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Añadir";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.txbApellido2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txbApellido, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txbNombre, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 130);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 56);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // txbApellido2
            // 
            this.txbApellido2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbApellido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbApellido2.Location = new System.Drawing.Point(530, 29);
            this.txbApellido2.Margin = new System.Windows.Forms.Padding(0);
            this.txbApellido2.Name = "txbApellido2";
            this.txbApellido2.Size = new System.Drawing.Size(262, 15);
            this.txbApellido2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(533, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido2 :";
            // 
            // txbApellido
            // 
            this.txbApellido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbApellido.Location = new System.Drawing.Point(266, 29);
            this.txbApellido.Margin = new System.Windows.Forms.Padding(0);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(262, 15);
            this.txbApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(269, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbNombre.Location = new System.Drawing.Point(2, 29);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(262, 15);
            this.txbNombre.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblNumeroTelefono, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txbTelefono, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 192);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 56);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(3, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(788, 28);
            this.lblNumeroTelefono.TabIndex = 0;
            this.lblNumeroTelefono.Text = "Numero de Telefono";
            // 
            // txbTelefono
            // 
            this.txbTelefono.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTelefono.Location = new System.Drawing.Point(3, 31);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(788, 22);
            this.txbTelefono.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btGuardar, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btCerrar, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 254);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(794, 121);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGuardar.Location = new System.Drawing.Point(267, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(258, 54);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCerrar.Location = new System.Drawing.Point(267, 63);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(258, 55);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cancelar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msPrincipal);
            this.Name = "FormularioUsuario";
            this.Text = "Formulario Usuario";
            this.Load += new System.EventHandler(this.FormularioUsuario_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem smiInsertar;
        private System.Windows.Forms.ToolStripMenuItem smiInsertarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menLibros;
        private System.Windows.Forms.ToolStripMenuItem menPrestamos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarUsuario;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox txbApellido2;
        private System.Windows.Forms.Label label5;
    }
}