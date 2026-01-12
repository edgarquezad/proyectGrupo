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

namespace ProyectoBiblioteca
{
    public partial class formularioPrincipal : Form
    {
   
        private controlador controladorPricipal = new controlador();
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        private void formularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menUsuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuario form = new AgregarUsuario();
            form.ControladorAgregarU = this.controladorPricipal;
            this.Hide();

            form.ShowDialog();

            this.Show();


        }

        
    }
}
