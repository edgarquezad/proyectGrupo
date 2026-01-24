using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Modelo;

namespace ProyectoBiblioteca.Controlador
{
    public class controlador
    {
        private Empleados lista = new Empleados();
        public void InsertarUsuario(string nombre, string Apellido1, string Apellido2, int telefono)
        {


            string errores = "";

            if (nombre.Trim().Length == 0)
                errores += "Falta el nombre" + Environment.NewLine;

            if (Apellido1.Trim().Length == 0)
                errores += "Falta el primer apellido" + Environment.NewLine;

            if (telefono <= 9)
            {
                errores += "falta numero de telefono " + Environment.NewLine;
            }

            if (lista.usuarioExistente(telefono))
                errores += $"Ya existe un usuario registrado con este telefono: {telefono} " + Environment.NewLine;




            if (!string.IsNullOrEmpty(errores)) // si el error es de¡iferente de nulo  vacio entra el error 
                throw new Exception(errores);



            lista.Agregar(nombre, Apellido1, Apellido2, telefono);



        }
        public List<Usuario> FiltrarUsuarios(string texto)

        {
            int id = 0;
            int.TryParse(texto, out id);
            List<Usuario> usuarios = lista.filtrarUsuarios(texto, id);
            if (usuarios.Count == 0)
                throw new Exception("No se encontraron usuarios con esos criterios");
            else

                return usuarios;

        }
        public List<Usuario> MostrarUsuarios()
        {
            List<Usuario> usuarios = lista.obtenerUsuarios();
            if (usuarios.Count == 0)
                throw new Exception("La lista de usuarios está vacía");
            else

                return usuarios;

        }


    }
}