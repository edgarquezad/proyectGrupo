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
   
        private controlador controladorPricipal = new controlador();   //// Se crea una única instancia del controlador de la clase controlador , se compartirá entre todos los formularios para mantener el mismo estado.//
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        private void formularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menUsuarios_Click(object sender, EventArgs e)
        {
            FormularioUsuario form = new FormularioUsuario(); // creamos una instancia del formularioUsuario //
            form.UsuarioU = this.controladorPricipal; //Se pasa el controlador principal al formulario Usuario para que ambos trabajen con la misma lógica y datos.
            this.Hide();   // oculatamos el formulario actual osea el principal , mientras mostramos el secundario osea formularioUsuario

            form.ShowDialog(); // mostramos el formulario Usuario  , form hace la intacia de ForumularioUsuario

            this.Show(); // se vuelve a mostrar el principal al cerrar el secundario 







        }

        private void menLibros_Click(object sender, EventArgs e)
        {
            FormularioLibros form = new FormularioLibros();
            form.libroL = this.controladorPricipal;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
