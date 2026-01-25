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
    public partial class FormularioLibros : Form
    {
        public controlador libroL { get; set; } //creamos los metos get y set para poder acceder a sus propiedades desde el formularioPricipal(Inicio)
                                                //permite que el formulario Pricipal(Inicio) le pase el controlador , no creamos otro controlador trabajamos con uno solo
        public FormularioLibros()
        {
            InitializeComponent();
        }

        private void FormularioLibros_Load(object sender, EventArgs e)
        {

        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
