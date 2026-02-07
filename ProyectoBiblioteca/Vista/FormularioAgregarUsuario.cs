using ProyectoBiblioteca.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Vista
{
    public partial class FormularioAgregarUsuario : Form
    {

        public controlador formularioAgregarUsu { get; set; }

        public FormularioAgregarUsuario()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            formularioAgregarUsu.InsertarUsuario(tbNombre.Text, tbApe1.Text, tbApe2.Text, int.Parse(tbTelefono.Text));
            MessageBox.Show($"Se ha agreado el usuario {tbNombre.Text}" );
            this.Close(); 
        
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = ""; 
            tbApe1.Text = ""; 
            tbApe2.Text = ""; 
            tbTelefono.Text = ""; 
        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
