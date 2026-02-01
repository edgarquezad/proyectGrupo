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
using ProyectoBiblioteca.Vista;

namespace ProyectoBiblioteca
{
    public partial class FormularioLibros : Form
    {
        public controlador controladorLibro { get; set; } //creamos los metos get y set para poder acceder a sus propiedades desde el formularioPricipal(Inicio)
                                                //permite que el formulario Pricipal(Inicio) le pase el controlador , no creamos otro controlador trabajamos con uno solo
        public FormularioLibros()
        {
            InitializeComponent();
        }

        private void FormularioLibros_Load(object sender, EventArgs e)
        {
            Cargar(controladorLibro.CargarDatos());
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)

        }


        public void Cargar(DataTable datos)
        {
            tableLayoutPanelLibros.Controls.Clear();

            int nuevaFila = 1;

            foreach (DataRow row in datos.Rows)
            {
             ControlUsuarioProyecto.ControlUsuario control = new ControlUsuarioProyecto.ControlUsuario();
                control.tipo = ControlUsuarioProyecto.ControlUsuario.TipoEntidad.Libro; //importante hay que elegir el tipo de entidad.
                control.Id = (int)row.Field<long>("id");
                control.Nombre = row.Field<string>("Titulo") ;
                control.Apellido = row.Field<string>("Escritor");
                control.eliminarLibro += Control_eliminarLibro;
                control.AgregarLibro += Control_AgregarLibro1;
                control.Dock = DockStyle.Fill;
                tableLayoutPanelLibros.RowCount = tableLayoutPanelLibros.RowCount + 1;
                tableLayoutPanelLibros.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tableLayoutPanelLibros.Controls.Add(control, 1, nuevaFila);
                nuevaFila++;
            }

        }

        private void Control_AgregarLibro1(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            formularioAgregarLibro form = new formularioAgregarLibro();
            form.controladorAgregarLib = this.controladorLibro;
            this.Hide();
            form.ShowDialog();
            this.Show();
            Cargar(controladorLibro.CargarDatos());
        }


        private void Control_eliminarLibro(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            controladorLibro.eliminarLibro(e.Id);
            Cargar(controladorLibro.CargarDatos());
            MessageBox.Show("libro eliminado correctamente");

        }
    
    }
}
