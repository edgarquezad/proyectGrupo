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
        public class ClickarBotonSeleccionarEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonSeleccionarEventArgs(int id)
            {
                Id = id;
            }
            public ClickarBotonSeleccionarEventArgs()
            {

            }
        }
        public event EventHandler<ClickarBotonSeleccionarEventArgs> eliminarUsuario;

        public event EventHandler<ClickarBotonSeleccionarEventArgs> AgregarUsuario;

        public event EventHandler<ClickarBotonSeleccionarEventArgs>eliminarLibro;

        public event EventHandler<ClickarBotonSeleccionarEventArgs> AgregarLibro;


        private void btAgregar_Click(object sender, EventArgs e)
        {
        
            if (tipo == TipoEntidad.Usuario)
            {
                AgregarUsuario?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
            }
            else if (tipo == TipoEntidad.Libro)
            {
                AgregarLibro?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
            }
            else
            {
                MessageBox.Show("Tipo NO ES libro");
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (tipo == TipoEntidad.Usuario)
            {
                eliminarUsuario?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
            }
            else if (tipo == TipoEntidad.Libro)
            {
                eliminarLibro?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
            }
            else
                throw new Exception("mal error ");

        }

        private void btEliminar_Click_1(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)  
            btEliminar_Click(sender, e);
            
        }

        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            btAgregar_Click(sender, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}