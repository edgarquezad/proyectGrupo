namespace ProyectoBiblioteca.Vista
{
    partial class FormularioAgregarUsuario
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
            this.tbApe1 = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApe1 = new System.Windows.Forms.Label();
            this.lApe2 = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApe2 = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipal.TabIndex = 1;
            this.tlpPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpPrincipal_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tbApe1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lApe1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lApe2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lTelefono, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbApe2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbTelefono, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btLimpiar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 424);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbApe1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbApe1, 2);
            this.tbApe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApe1.Location = new System.Drawing.Point(202, 174);
            this.tbApe1.Margin = new System.Windows.Forms.Padding(2);
            this.tbApe1.Name = "tbApe1";
            this.tbApe1.Size = new System.Drawing.Size(554, 20);
            this.tbApe1.TabIndex = 9;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(16, 148);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(182, 24);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            this.lNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lApe1
            // 
            this.lApe1.AutoSize = true;
            this.lApe1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lApe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lApe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApe1.Location = new System.Drawing.Point(16, 172);
            this.lApe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lApe1.Name = "lApe1";
            this.lApe1.Size = new System.Drawing.Size(182, 24);
            this.lApe1.TabIndex = 2;
            this.lApe1.Text = "1ª Apellido";
            this.lApe1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lApe2
            // 
            this.lApe2.AutoSize = true;
            this.lApe2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lApe2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lApe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApe2.Location = new System.Drawing.Point(16, 196);
            this.lApe2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lApe2.Name = "lApe2";
            this.lApe2.Size = new System.Drawing.Size(182, 24);
            this.lApe2.TabIndex = 3;
            this.lApe2.Text = "2ª Apellido";
            this.lApe2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(16, 220);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(182, 24);
            this.lTelefono.TabIndex = 4;
            this.lTelefono.Text = "Telefono";
            this.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNombre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbNombre, 2);
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.Location = new System.Drawing.Point(202, 150);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(554, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbApe2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbApe2, 2);
            this.tbApe2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApe2.Location = new System.Drawing.Point(202, 198);
            this.tbApe2.Margin = new System.Windows.Forms.Padding(2);
            this.tbApe2.Name = "tbApe2";
            this.tbApe2.Size = new System.Drawing.Size(554, 20);
            this.tbApe2.TabIndex = 7;
            // 
            // tbTelefono
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbTelefono, 2);
            this.tbTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTelefono.Location = new System.Drawing.Point(202, 222);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(554, 20);
            this.tbTelefono.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(202, 246);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(368, 28);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(574, 246);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(132, 28);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(16, 246);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(132, 28);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormularioAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioAgregarUsuario";
            this.Text = "FormularioAgregarUsuario";
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbApe1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApe1;
        private System.Windows.Forms.Label lApe2;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApe2;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCancelar;
    }
}