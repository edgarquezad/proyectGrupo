using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo.Libro
{
    internal class ListaLibros
    {
        private List<Libro> Libros = new List<Libro>();
        private int siguienteId = 1;
        private string ruta = @"Data Source =C:\Users\Edgar Q\Desktop\ProyectoGrupo\proyectGrupo\ProyectoBiblioteca\Biblioteca.db;version=3";

        public ListaLibros(List<Libro> libros, int siguienteId, string ruta)
        {
            Libros = libros;
            this.siguienteId = siguienteId;
            this.ruta = ruta;
        }



        public void AgregarLibros(string Titulo, string Escritor, int Ano_edicion, string Sinopsis, int Disponible)
        {
            Libro libro = new Libro(siguienteId, Titulo, Escritor, Ano_edicion, Sinopsis, Disponible);
            Libros.Add(libro);
            siguienteId++;

        }

        public List<Libro> filtrarLibro(string texto, int id)
        {

            List<Libro> Resultadolibros = new List<Libro>();

            foreach (Libro libro in Libros)
            {
                if (libro.Id == id)
                {
                    Resultadolibros.Add(libro);
                }
                else if (libro.Titulo == texto)
                {
                    Resultadolibros.Add(libro);
                }
                else if (libro.Escritor == texto)
                {
                    Resultadolibros.Add(libro);
                }

            }
            return Resultadolibros;

        }



    }
}

