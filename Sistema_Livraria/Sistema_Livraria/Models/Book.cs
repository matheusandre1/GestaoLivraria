namespace Sistema_Livraria.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Genero {  get; set; } 

        public double Preco { get; set; }

        public int  Quantidade { get; set; }
    }
}
