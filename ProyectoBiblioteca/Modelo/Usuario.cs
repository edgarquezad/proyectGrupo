using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Telefono { get; set; }

        public Usuario(int id, string nombre, string apellido1, string apellido2, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Nombre:{Nombre} |Apellido1 :{Apellido1}|Apellido2: {Apellido2} |telefono:{Telefono}";

        }

    }
}

