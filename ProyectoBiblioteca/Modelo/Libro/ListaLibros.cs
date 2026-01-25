using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo.Libro
{
  internal class ListaLibros
    {
        
        private string ruta = Properties.Settings.Default.conexion;



        public void AgregarLibros(string Titulo, string Escritor, int Ano_edicion, string Sinopsis, int Disponible)
        {
            SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Libros (Titulo, Escritor, Ano_edicion, Sinopsis, Disponible)
                                                    VALUES (@Titulo, @Escritor, @Ano_Edicion, @Sinopsis, @Disponible)");
            cmd.Parameters.AddWithValue("@Titulo", Titulo);
            cmd.Parameters.AddWithValue("@Escritor", Escritor);
            cmd.Parameters.AddWithValue("@Ano_Edicion", Ano_edicion);
            cmd.Parameters.AddWithValue("@Sinopsis", Sinopsis);
            cmd.Parameters.AddWithValue("@Disponible", Disponible);
           // Conexion.Ejecuta(ruta, cmd);
           
            Conexion.Ejecuta(Properties.Settings.Default.conexion, cmd);


        }

        public List<Libro> filtrarLibro(string texto, int id)
        {

            List<Libro> Resultadolibros = new List<Libro>();
            SQLiteCommand cmd;
            if (id > 0)
            {
                cmd = new SQLiteCommand("SELECT * FROM Libros WHERE ID = @id ");
                cmd.Parameters.AddWithValue("@id", id);
            }
            else
            {
                cmd = new SQLiteCommand("SELECT * FROM Libros WHERE Titulo LIKE @Titulo OR Escritor LIKE @Escritor");
                cmd.Parameters.AddWithValue("@Titulo", texto);
                cmd.Parameters.AddWithValue("@Escritor", texto);
            }
            using (SQLiteDataReader reader = Conexion.GetDataReader(ruta, cmd))
            {
                while (reader.Read())
                {
                    Resultadolibros.Add(new Libro(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetInt32(5)));
                }

            }
            return Resultadolibros;


        }
        public List<Libro> obtenerLibros()
        {
            List<Libro> resultadoLibros = new List<Libro>();
            SQLiteCommand cmd;
            string sql = "SELECT * FROM Libros";
            cmd = new SQLiteCommand(sql);
            using (SQLiteDataReader dr = Conexion.GetDataReader(ruta,cmd))
            {
                while (dr.Read())
                {
                    resultadoLibros.Add(new Libro
                        (dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3),
                        dr.GetString(4),
                        dr.GetInt32(5)
                        ));

                }

            }
            return resultadoLibros;

        }
        public void EliminarLibro(int id)
        {
            string sql = $"DELETE FROM Libros WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
           // Conexion.Ejecuta(Properties.Settings.Default.conexion, cmd);
            Conexion.Ejecuta(ruta,cmd);
        }
    }


    
}

