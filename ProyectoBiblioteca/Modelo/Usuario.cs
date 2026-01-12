using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email {  get; set; }
        public int Id { get; set; }




        public Usuario(string nombre, string apellido1,string email, int id)
        {
            Nombre = nombre;
            Apellido = apellido1;
            Email = email;
            Id = id;


        }



        public override string ToString()
        {
            return $"Id: {Id} | Nombre:{Nombre} |Apellido :{Apellido} |Email : {Email}";

        }

    }
}

