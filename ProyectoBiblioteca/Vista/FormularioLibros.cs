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
            cargarDatos();
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)

        }

        private void tableLayoutPanelLibros_Paint(object sender, EventArgs e)
        {
            
        }
        public void cargarDatos() ///mallll

        {
             
            tableLayoutPanelLibros.Controls.Clear();
            tableLayoutPanelLibros.RowStyles.Clear();
            tableLayoutPanelLibros.RowCount = 0;

            int fila = 0;

            foreach (Libro libro in libroL.MostrarLibros()) {
                {
                    ControlUsuarioProyecto.ControlUsuario control = new ControlUsuarioProyecto.ControlUsuario();
                    control.tipo = ControlUsuarioProyecto.ControlUsuario.TipoEntidad.Libro;  // en el control de usuario usamos un enum ( libro o usuario ) para poder usar la funciones elimniarLibro EliminarUsuario etc con un mismo boton

                    control.Id = libro.Id;
                    control.Nombre = libro.Titulo;
                    control.Apellido = libro.Escritor; // reutilizas el control
                    control.Seleccionar = libro.Disponible == 0;

                    control.AgregarLibro += Control_AgregarLibro1;
                    control.eliminarLibro += Control_eliminarLibro;

                    control.Dock = DockStyle.Fill;

                    tableLayoutPanelLibros.RowCount++;
                    tableLayoutPanelLibros.RowStyles.Add(
                        new RowStyle(SizeType.AutoSize));

                    tableLayoutPanelLibros.Controls.Add(control, 0, fila);
                    fila++;
                }




            }}

        private void Control_eliminarLibro(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
           
            libroL.eliminarLibro(e.Id);
            cargarDatos();
            MessageBox.Show("libro eliminado correctamente");
           
        }

        private void Control_AgregarLibro1(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            throw new NotImplementedException();
        }

 
    
    }
}
