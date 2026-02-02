using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;

namespace ProyectoBiblioteca.Vista
{
    public partial class formularioAgregarLibro : Form
    {
        public controlador controladorAgregarLib { get; set; }

        public formularioAgregarLibro()
        {
            InitializeComponent();
        }

        private void formularioAgregarLibro_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void limpiarCampos()
        {
            tbTitulo.Text = "";
            tbEscritor.Text = "";
            tbAno_edicion.Text = "";
            tbSinopsis.Text = "";
            tbDisponible.Text = "";
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            controladorAgregarLib.InsertarLibro(tbTitulo.Text, tbEscritor.Text, int.Parse(tbAno_edicion.Text), tbSinopsis.Text, int.Parse(tbDisponible.Text));
    
            this.Close();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menUsuarios_Click(object sender, EventArgs e)
        {
         
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
