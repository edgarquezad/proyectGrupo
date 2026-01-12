using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Modelo;

namespace ProyectoBiblioteca
{
    public partial class AgregarUsuario : Form
    {

       
        public controlador ControladorAgregarU{ get; set; }

        public AgregarUsuario()
        {

            InitializeComponent();
        }

        private void limpiar()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbEmail.Text = "";
            txbBuscarUsuario.Text = "";
           

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorAgregarU.InsertarUsuario(txbNombre.Text, txbApellido.Text, txbEmail.Text);
                MessageBox.Show("has insertado correctamente un usuarui nuevo ");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txbBuscarUsuario.Text;       
                var filtrado =ControladorAgregarU.FiltrarUsuarios(texto);

                foreach(Usuario usarioFiltrado in filtrado)
                {
                    MessageBox.Show(usarioFiltrado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
           
          
        }

    
    }
}
