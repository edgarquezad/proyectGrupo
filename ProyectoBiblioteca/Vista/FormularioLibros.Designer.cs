namespace ProyectoBiblioteca
{
    partial class FormularioLibros
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
            this.tableLayoutPanelLibros = new System.Windows.Forms.TableLayoutPanel();
            this.msPrincipal.SuspendLayout();
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
            // tableLayoutPanelLibros
            // 
            this.tableLayoutPanelLibros.AutoScroll = true;
            this.tableLayoutPanelLibros.ColumnCount = 1;
            this.tableLayoutPanelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLibros.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanelLibros.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanelLibros.Name = "tableLayoutPanelLibros";
            this.tableLayoutPanelLibros.RowCount = 1;
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanelLibros.Size = new System.Drawing.Size(800, 378);
            this.tableLayoutPanelLibros.TabIndex = 4;
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelLibros);
            this.Controls.Add(this.msPrincipal);
            this.Name = "FormularioLibros";
            this.Text = "FormularioLibros";
            this.Load += new System.EventHandler(this.FormularioLibros_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLibros;
    }
}