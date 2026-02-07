using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Vista;
using System;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormularioUsuario : Form
    {
        public controlador UsuarioU { get; set; }


        public FormularioUsuario()
        {

            InitializeComponent();
        }

        private void limpiar()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbApellido2.Text = "";
            txbTelefono.Text = "";
            txbBuscarUsuario.Text = "";
        }

        private void btGuardar_Click(object sender, EventArgs e)

        {
            try
            {
                UsuarioU.InsertarUsuario(txbNombre.Text, txbApellido.Text, txbApellido2.Text, (int.Parse)(txbTelefono.Text));
                MessageBox.Show("has insertado correctamente un usuario nuevo ");
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
                var filtrado = UsuarioU.FiltrarUsuarios(texto);

                foreach (string usuario in filtrado)
                {
                    MessageBox.Show(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            form.formularioAgregarUsu = this.UsuarioU;
            this.Hide();
            form.ShowDialog();
            this.Show();


        }
    }
}
