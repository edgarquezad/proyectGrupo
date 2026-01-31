using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo
{
    internal class ListaUsuarios
    {
        private string ruta = Properties.Settings.Default.conexion;

        public void Agregar(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string sql = "INSERT INTO Usuarios (Nombre,Apellido_1,Apellido_2,Telefono) VALUES ( @Nombre, @Apellido_1,@Apellido_2,@Telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue(@"Nombre",nombre);
            cmd.Parameters.AddWithValue(@"Apellido_1",Apellido1);
            cmd.Parameters.AddWithValue(@"Apellido_2",Apellido2);
            cmd.Parameters.AddWithValue(@"Telefono",telefono);
            Conexion.Ejecuta(ruta, cmd);


        }
        public List<Usuario> filtrarUsuarios(string texto, int id)
        {
            List<Usuario> resultado = new List<Usuario>();
            SQLiteCommand cmd;


            {

                if (id > 0)
                {
                    string sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios WHERE ID = @id";
                    cmd = new SQLiteCommand(sql);

                    cmd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                  string sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios WHERE Nombre LIKE @texto OR Apellido_1 LIKE @texto OR Apellido_2 LIKE @texto";
                    cmd= new SQLiteCommand(sql);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%"); // para que sirven los %% no lo veo
                }



                using (SQLiteDataReader dr = Conexion.GetDataReader(ruta, cmd))
                {
                    while (dr.Read())
                    {
                        resultado.Add(new Usuario(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetInt32(4)
                        ));
                    }
                }
            }
            return resultado;
        }

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> lista2 = new List<Usuario>();

            SQLiteCommand cmd;
            
                string sql = "SELECT ID,Nombre,Apellido_1,Apellido_2,Telefono FROM Usuarios";
                cmd = new SQLiteCommand(sql);
        
                using (SQLiteDataReader dr = Conexion.GetDataReader(sql,cmd))
                {
                    while (dr.Read())
                    {
                        lista2.Add(new Usuario(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                             dr.GetInt32(4)

                        ));
                    }
                }
            

            return lista2;
        }

        /* public bool usuarioExistente(int telefono) //
         {
              foreach (Usuario usuarioR in Usuarios)
               {
             //      if (usuarioR.Telefono == telefono)
                   {
                       return true;
                   }
               }

           return false;

           }*/

    }
}
