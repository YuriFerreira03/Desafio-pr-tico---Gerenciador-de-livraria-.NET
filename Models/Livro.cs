namespace MyFirstApi.Models
{
    public class Livro
    {
        //dados do livro
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Preco { get; set; } = string.Empty;
        public string QtnEstoque { get; set; } = string.Empty;

    }
}
