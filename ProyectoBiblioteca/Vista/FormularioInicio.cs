using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Vista;
using System;
using System.Windows.Forms;

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

        private void InsertarFormulario(Form formulario)
        {

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();

        }

        private void menUsuarios_Click(object sender, EventArgs e)
        {
 

            var form = new FormularioUsuario();
 
            form.controladorUsuario = this.controladorPricipal;
            InsertarFormulario(form);
            

        }

        private void menLibros_Click(object sender, EventArgs e)
        {
            var form = new FormularioLibros();
            form.controladorLibro = this.controladorPricipal; // Se pasa el controlador principal al formulario Libros para que ambos trabajen con la misma lógica y datos.
            InsertarFormulario(form);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menPrestamos_Click(object sender, EventArgs e)
        {

        }
    }
}
