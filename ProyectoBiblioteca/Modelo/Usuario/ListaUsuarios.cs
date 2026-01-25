using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo
{
    internal class Empleados
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        private int siguienteId = 1;
        private string ruta = Properties.Settings.Default.conexion;



        public void Agregar(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            Usuario usuario = new Usuario(siguienteId, nombre, Apellido1, Apellido2, telefono);
            Usuarios.Add(usuario);
            siguienteId++;
        }
        public List<Usuario> filtrarUsuarios(string texto, int id)
        {
            List<Usuario> resultado = new List<Usuario>();

            using (SQLiteConnection cnn = Conexion.Conectar(ruta))
            {

                string sql;
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cnn;
                

                if (id > 0)
    {
        sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono 
    FROM Usuarios 
    WHERE ID = @id";

        cmd.Parameters.AddWithValue("@id", id);
    }
    else
    {
        sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono 
    FROM Usuarios 
    WHERE Nombre LIKE @texto 
       OR Apellido_1 LIKE @texto 
       OR Apellido_2 LIKE @texto";

        cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
    }

    cmd.CommandText = sql;

    using (SQLiteDataReader dr = cmd.ExecuteReader())
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
            List<Usuario> lista = new List<Usuario>();

            using (SQLiteConnection cnn = Conexion.Conectar(ruta))
            {
                string sql = "SELECT ID,Nombre,Apellido_1,Apellido_2,Telefono FROM Usuarios";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnn))
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Usuario(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                             dr.GetInt32(4)

                        ));
                    }
                }
            }

            return lista;
        }

        public bool usuarioExistente(int telefono)
        {
            foreach (Usuario usuarioR in Usuarios)
            {
                if (usuarioR.Telefono == telefono)
                {
                    return true;
                }
            }

            return false;

        }




    }
}
