namespace ProyectoBiblioteca.Vista
{
    partial class formularioAgregarLibro
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAno_edicion = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbEscritor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAno_edicion = new System.Windows.Forms.Label();
            this.tbSinopsis = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbDisponible = new System.Windows.Forms.TextBox();
            this.disponible = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.smiInsertar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiInsertarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpPrincipal.Controls.Add(this.msPrincipal, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tbEscritor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lEscritor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lAno_edicion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbSinopsis, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAno_edicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbDisponible, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.disponible, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btLimpiar, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 88);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 346);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbEmail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbEmail, 2);
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmail.Location = new System.Drawing.Point(203, 167);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(540, 22);
            this.tbEmail.TabIndex = 8;
            // 
            // tbAno_edicion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAno_edicion, 2);
            this.tbAno_edicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAno_edicion.Location = new System.Drawing.Point(203, 141);
            this.tbAno_edicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAno_edicion.Name = "tbAno_edicion";
            this.tbAno_edicion.Size = new System.Drawing.Size(540, 22);
            this.tbAno_edicion.TabIndex = 7;
            // 
            // tbTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbTitulo, 2);
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitulo.Location = new System.Drawing.Point(203, 89);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(540, 22);
            this.tbTitulo.TabIndex = 6;
            // 
            // tbEscritor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbEscritor, 2);
            this.tbEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEscritor.Location = new System.Drawing.Point(203, 115);
            this.tbEscritor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEscritor.Name = "tbEscritor";
            this.tbEscritor.Size = new System.Drawing.Size(540, 22);
            this.tbEscritor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(21, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(176, 26);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Titulo";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEscritor.Location = new System.Drawing.Point(21, 113);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(176, 26);
            this.lEscritor.TabIndex = 2;
            this.lEscritor.Text = "Escritor";
            this.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lAno_edicion
            // 
            this.lAno_edicion.AutoSize = true;
            this.lAno_edicion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lAno_edicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAno_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAno_edicion.Location = new System.Drawing.Point(21, 139);
            this.lAno_edicion.Name = "lAno_edicion";
            this.lAno_edicion.Size = new System.Drawing.Size(176, 26);
            this.lAno_edicion.TabIndex = 3;
            this.lAno_edicion.Text = "Año edicion";
            this.lAno_edicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSinopsis
            // 
            this.tbSinopsis.AutoSize = true;
            this.tbSinopsis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSinopsis.Location = new System.Drawing.Point(21, 165);
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(176, 26);
            this.tbSinopsis.TabIndex = 4;
            this.tbSinopsis.Text = "Sinopsis";
            this.tbSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(203, 221);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(358, 36);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbDisponible
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbDisponible, 2);
            this.tbDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDisponible.Location = new System.Drawing.Point(203, 194);
            this.tbDisponible.Name = "tbDisponible";
            this.tbDisponible.Size = new System.Drawing.Size(540, 22);
            this.tbDisponible.TabIndex = 11;
            // 
            // disponible
            // 
            this.disponible.AutoSize = true;
            this.disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible.Location = new System.Drawing.Point(21, 191);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(176, 28);
            this.disponible.TabIndex = 12;
            this.disponible.Text = "dispobible";
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(567, 221);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(176, 36);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
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
            this.msPrincipal.TabIndex = 3;
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
            this.menUsuarios.Click += new System.EventHandler(this.menUsuarios_Click);
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
            // formularioAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "formularioAgregarLibro";
            this.Text = "formularioAgregarLibro";
            this.Load += new System.EventHandler(this.formularioAgregarLibro_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
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
        private System.Windows.Forms.TextBox tbEscritor;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAno_edicion;
        private System.Windows.Forms.Label tbSinopsis;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAno_edicion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbDisponible;
        private System.Windows.Forms.Label disponible;
        private System.Windows.Forms.Button btLimpiar;
    }
}