using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Agregar(string nombre, string Apellido, string email)
        {
            Usuario usuario = new Usuario(nombre, Apellido, email, siguienteId);
            Usuarios.Add(usuario);
            siguienteId++;
        }
        public List<Usuario> filtrarUsuarios(string texto ,int id  )
        {
            List<Usuario>resultado = new List<Usuario>();

            foreach (Usuario usuarioBuscar in Usuarios)
            {
                if (id > 0)
                {
                    if (usuarioBuscar.Id == id)
                    {
                        resultado.Add(usuarioBuscar);
                    }
                    else if ((usuarioBuscar.Nombre == texto)
                            || (usuarioBuscar.Apellido == texto)
                            || (usuarioBuscar.Email == texto))

                    {
                        resultado.Add(usuarioBuscar);
                    }


                }
            }

            return resultado;
        }
        public List<Usuario> obtenerUsuarios() {
            return Usuarios;

                }


        public bool usuarioExistente(string email) {
            foreach(Usuario usuarioR  in Usuarios)
            {
              if(usuarioR.Email ==email)
                {
                    return true;
                }
            }

            return false;
        
        }
      
        

    
    }
}
