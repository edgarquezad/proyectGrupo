using ProyectoBiblioteca.Modelo;
using ProyectoBiblioteca.Modelo.Libro;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoBiblioteca.Controlador
{
    public class controlador
    {

        /// <summary>
        ///USUARIO  controlador de insertar usuaruio y filtrar usuario , "faltaria eliminar usuario, intentar completarlo "
        /// </summary>
        private ListaUsuarios listaUsuarios = new ListaUsuarios();
        private ListaLibros listaLibros = new ListaLibros();



        public void InsertarUsuario(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string errores = "";

            if (nombre.Trim().Length == 0)
                errores += "Falta el nombre" + Environment.NewLine;

            if (Apellido1.Trim().Length == 0)
                errores += "Falta el primer apellido" + Environment.NewLine;

            if (telefono <= 9)

                errores += "falta numero de telefono " + Environment.NewLine;


            if (!string.IsNullOrEmpty(errores)) // si el error es de¡iferente de nulo  vacio entra el error 
                throw new Exception(errores);
            listaUsuarios.Agregar(nombre, Apellido1, Apellido2, telefono);
        }


        public List<string> FiltrarUsuarios(string texto)

        {
            int id;
            bool esId = int.TryParse(texto, out id);
            List<Usuario> usuarios;

            if (esId)
                usuarios = listaUsuarios.filtrarUsuarios("", id);
            else
                usuarios = listaUsuarios.filtrarUsuarios(texto, 0);

            if (usuarios.Count == 0)
                throw new Exception("No se encontraron usuarios con esos criterios");

            List<string> resultado = new List<string>();

            foreach (Usuario u in usuarios)

                resultado.Add($"{u.Id} - {u.Nombre} {u.Apellido1} {u.Apellido2} ({u.Telefono})");
            return resultado;

        }
        public List<Usuario> MostrarUsuarios()
        {
            List<Usuario> usuarios = listaUsuarios.obtenerUsuarios();
            if (usuarios.Count == 0)
                throw new Exception("La lista de usuarios está vacía");
            else

                return usuarios;

        }

        // Controlador de Libros 

        /* public List<Libro> MostrarLibros() {   no consigo ponerlo a la vista sin comprometer mvc usaremos el DataTable
               return listaLibros.obtenerLibros();
          }*/

        public bool eliminarLibro(int id)
        {
            listaLibros.EliminarLibro(id);

            return true;
        }
        public DataTable CargarDatos()
        {
            return listaLibros.CargarTodo();
        }

        public void InsertarLibro(string titulo, string escritor, int ano_edicion, string sinopsis, int disponible)
        {
            if (titulo.Trim().Length == 0)
                throw new Exception("Falta el titulo" + Environment.NewLine);
            if (escritor.Trim().Length == 0)
                throw new Exception("Falta el escritor" + Environment.NewLine);
            if (ano_edicion <= 0)
                throw new Exception("Falta el año de edicion " + Environment.NewLine);

            listaLibros.AgregarLibros(titulo, escritor, ano_edicion, sinopsis, disponible);
        }





    }
}
