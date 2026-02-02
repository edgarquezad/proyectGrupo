namespace ProyectoBiblioteca
{
    partial class formularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.smiInsertar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
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
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(800, 72);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "MenuStrip1";
            // 
            // smiInsertar
            // 
            this.smiInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.smiInsertar.Image = global::ProyectoBiblioteca.Properties.Resources.Person_Male_Skin_Type_3;
            this.smiInsertar.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.smiInsertar.Name = "smiInsertar";
            this.smiInsertar.Size = new System.Drawing.Size(240, 68);
            this.smiInsertar.Text = "Ayuntamiento Vitoria Gasteiz";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 68);
            // 
            // menUsuarios
            // 
            this.menUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menUsuarios.Image = global::ProyectoBiblioteca.Properties.Resources.Add_User_Male1;
            this.menUsuarios.Margin = new System.Windows.Forms.Padding(45, 10, 10, 10);
            this.menUsuarios.Name = "menUsuarios";
            this.menUsuarios.Size = new System.Drawing.Size(103, 48);
            this.menUsuarios.Text = "Usuarios";
            this.menUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menUsuarios.Click += new System.EventHandler(this.menUsuarios_Click);
            // 
            // menLibros
            // 
            this.menLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menLibros.Image = global::ProyectoBiblioteca.Properties.Resources.Add_Book;
            this.menLibros.Margin = new System.Windows.Forms.Padding(15);
            this.menLibros.Name = "menLibros";
            this.menLibros.Padding = new System.Windows.Forms.Padding(5);
            this.menLibros.Size = new System.Drawing.Size(91, 38);
            this.menLibros.Text = "Libros ";
            this.menLibros.Click += new System.EventHandler(this.menLibros_Click);
            // 
            // menPrestamos
            // 
            this.menPrestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menPrestamos.Image = global::ProyectoBiblioteca.Properties.Resources.Books;
            this.menPrestamos.Margin = new System.Windows.Forms.Padding(15);
            this.menPrestamos.Name = "menPrestamos";
            this.menPrestamos.Size = new System.Drawing.Size(115, 38);
            this.menPrestamos.Text = "Prestamos";
            this.menPrestamos.Click += new System.EventHandler(this.menPrestamos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // formularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "formularioPrincipal";
            this.Text = "Pagina Inicio";
            this.Load += new System.EventHandler(this.formularioPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem smiInsertar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menLibros;
        private System.Windows.Forms.ToolStripMenuItem menPrestamos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

