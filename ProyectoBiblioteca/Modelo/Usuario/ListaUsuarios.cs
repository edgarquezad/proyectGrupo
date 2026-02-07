using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ProyectoBiblioteca.Modelo
{
    internal class ListaUsuarios
    {
        private string ruta = Properties.Settings.Default.conexion;

        public void Agregar(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string sql = "INSERT INTO Usuarios (Nombre,Apellido_1,Apellido_2,Telefono) VALUES ( @Nombre, @Apellido_1,@Apellido_2,@Telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue(@"Nombre", nombre);
            cmd.Parameters.AddWithValue(@"Apellido_1", Apellido1);
            cmd.Parameters.AddWithValue(@"Apellido_2", Apellido2);
            cmd.Parameters.AddWithValue(@"Telefono", telefono);
            Conexion.Ejecuta(ruta, cmd);


        }
        public DataTable filtrarUsuarios(string texto, int id)
        {

            DataTable datos = new DataTable();
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
                    cmd = new SQLiteCommand(sql);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%"); // para que sirven los %% no lo veo
                }

                datos = Conexion.GetDataTable(ruta, cmd);
                
             
            }
            return datos;
        }

      

        public void eliminarUsuario(int id)
        {
            string sql = $"DELETE FROM Usuarios WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            Conexion.Ejecuta(ruta, cmd);
        }
        public DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Usuarios";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = Conexion.GetDataTable(ruta, cmd);
            return datos;
        }

        public DataTable editarUsuario(int id )
        {
            DataTable datos = new DataTable();
            string sql = $"UPDATE Usuarios SET Nombre=@Nombre, Apellido_1=@Apellido_1, Apellido_2=@Apellido_2, Telefono=@Telefono WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);

           datos = Conexion.GetDataTable(ruta, cmd);
            return datos;
        }

    }
}
