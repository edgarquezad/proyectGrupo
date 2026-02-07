namespace ProyectoBiblioteca.Modelo.Libro
{
    public class Libro
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Escritor { get; set; }
        public int Ano_Edicion { get; set; }
        public string Sinopsis { get; set; }
        public int Disponible { get; set; }

        public Libro(int id, string titulo, string escritor, int ano_Edicion, string sinopsis, int disponible)
        {
            Id = id;
            Titulo = titulo;
            Escritor = escritor;
            Ano_Edicion = ano_Edicion;
            Sinopsis = sinopsis;
            Disponible = disponible;
        }

    }
}
