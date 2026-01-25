using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUsuarioProyecto
{
    public partial class ControlUsuario : UserControl
    {

        public enum TipoEntidad { Usuario ,Libro}
        public TipoEntidad tipo {get; set;}
            
        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void tblpPricipal_Paint(object sender, PaintEventArgs e)
        {

        }
        public override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = new Size(560, 60);
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nombre
        {
            get => txtNombre.Text;
            set => txtNombre.Text = value;
        }

        public string Apellido
        {
            get => txtApellido.Text;
            set => txtApellido.Text = value;
        }

        public bool Seleccionar
        {
            get => ckSeleccionar.Checked;
            set => ckSeleccionar.Checked = value;


        }
        private int id;

        public event EventHandler<int> eliminarUsuario;

        public event EventHandler<int> AgregarUsuario;

        public event EventHandler<int> eliminarLibro;

        public event EventHandler<int> AgregarLibro;


        public void rellenarFormulario()
        {
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tipo == TipoEntidad.Usuario) {
                AgregarUsuario?.Invoke(this, Id);
            }
            else if (tipo == TipoEntidad.Libro) {
                AgregarLibro?.Invoke(this, Id);
            }
       
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarUsuario?.Invoke(this, Id);
            eliminarLibro?.Invoke(this, Id);

        }

        private void ckSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)
            {
                DialogResult resultado = MessageBox.Show("estas seguro de dar de baja al usuario "," dar de baja ", 
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                {
                    ckSeleccionar.Checked = false;


                }
                if (resultado == DialogResult.OK)
                {
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    ckSeleccionar.Checked = false;
                }


            }
        }
    }
}