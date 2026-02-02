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
            this.tableLayoutPanelLibros = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLibros
            // 
            this.tableLayoutPanelLibros.AutoScroll = true;
            this.tableLayoutPanelLibros.ColumnCount = 1;
            this.tableLayoutPanelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLibros.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLibros.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanelLibros.Name = "tableLayoutPanelLibros";
            this.tableLayoutPanelLibros.RowCount = 1;
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanelLibros.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelLibros.TabIndex = 4;
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelLibros);
            this.Name = "FormularioLibros";
            this.Text = "FormularioLibros";
            this.Load += new System.EventHandler(this.FormularioLibros_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLibros;
    }
}