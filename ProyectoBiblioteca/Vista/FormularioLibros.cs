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
using ProyectoBiblioteca.Modelo.Libro;

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
            cargarDatos(libroL.MostrarLibros());
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)

        }

        private void tableLayoutPanelLibros_Paint(object sender, PaintEventArgs e)
        {

        }
        public void cargarDatos(List<Libro> libros) ///mallll

        {
            tableLayoutPanelLibros.Controls.Clear();
            tableLayoutPanelLibros.RowStyles.Clear();
            tableLayoutPanelLibros.RowCount = 0;

            int fila = 0;

            foreach (Libro libro in libros)
            {
                ControlUsuarioProyecto.ControlUsuario control =
                    new ControlUsuarioProyecto.ControlUsuario();

                control.Id = libro.Id;
                control.Nombre = libro.Titulo;
                control.Apellido = libro.Escritor; // reutilizas el control
                control.Seleccionar = libro.Disponible == 0;

                control.eliminarLibro += Control_EliminarLibro;
                control.AgregarLibro += Control_AgregarLibro;

                control.Dock = DockStyle.Fill;

                tableLayoutPanelLibros.RowCount++;
                tableLayoutPanelLibros.RowStyles.Add(
                    new RowStyle(SizeType.AutoSize));

                tableLayoutPanelLibros.Controls.Add(control, 0, fila);
                fila++;
            }




        }
        private void Control_EliminarLibro(object sender, int e)
        {
            throw new NotImplementedException();
        }
        private void Control_AgregarLibro(object sender, int e)
        {
            throw new NotImplementedException();
        }


        private void controlUsuario1_Load(object sender, EventArgs e)
        {

        }
    }
}
