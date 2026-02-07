using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Modelo;
using ProyectoBiblioteca.Vista;

namespace ProyectoBiblioteca
{
    public partial class FormularioUsuario : Form
    {
        public controlador controladorUsuario { get; set; }


        public FormularioUsuario()
        {

            InitializeComponent();
        }

  


        private void btBuscar_Click(object sender, EventArgs e)
        {
            string texto = txbBuscarUsuario.Text;
            if (string.IsNullOrEmpty(texto))
            {
                Cargar(controladorUsuario.CargarDatosUsuario());
            }
            else
            {
                
                    var resultado = controladorUsuario.FiltrarUsuarios(texto);

                    if (resultado.Rows.Count > 0)
                    {
                        Cargar(controladorUsuario.FiltrarUsuarios(texto));
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron usuarios con el criterio de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar(controladorUsuario.CargarDatosUsuario());
                    }

                }
               
            


        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio
        }

        private void FormularioUsuario_Load(object sender, EventArgs e)
        {
        
          
            
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FormularioAgregarUsuario form = new FormularioAgregarUsuario();
            form.formularioAgregarUsu = this.controladorUsuario;
            this.Hide();
            form.ShowDialog();
            this.Show();


        }

 

   

        public void Cargar(DataTable datos)
        {
            panelUsuarios.Controls.Clear();

            int nuevaFila = 1;

            foreach (DataRow row in datos.Rows)
            {
                ControlUsuarioProyecto.ControlUsuario control = new ControlUsuarioProyecto.ControlUsuario();
                control.tipo = ControlUsuarioProyecto.ControlUsuario.TipoEntidad.Libro; //importante hay que elegir el tipo de entidad.
                control.Id = (int)row.Field<long>("id");
                control.Nombre = row.Field<string>("Nombre");
                control.Apellido = row.Field<string>("Apellido_1");
                control.Editar += Control_Editar;
                control.Eliminar += Control_Eliminar;
                control.Dock = DockStyle.Fill;
               panelUsuarios.RowCount = panelUsuarios.RowCount + 1;
                panelUsuarios.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
               panelUsuarios.Controls.Add(control, 1, nuevaFila);
                nuevaFila++;
            }

        }

        private void Control_Editar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            FormularioAgregarUsuario form = new FormularioAgregarUsuario();
            form.formularioAgregarUsu = this.controladorUsuario;
            this.Hide();
            form.ShowDialog();
            this.Show();

            string sql = "SELECT id, Nombre, Apellido_1 FROM Usuario WHERE id = @id";

            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@id", e.Id);

            Cargar(controladorUsuario.CargarDatosUsuario());
            controladorUsuario.EditarUsuario(e.Id);

            MessageBox.Show("Usuario editado correctamente");

        }

        private void Control_Eliminar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            controladorUsuario.eliminarUsuario(e.Id);
            Cargar(controladorUsuario.CargarDatosUsuario());
            MessageBox.Show("Usuario eliminado correctamente");

        }

     

        private void panelUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
