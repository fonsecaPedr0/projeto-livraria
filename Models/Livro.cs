namespace Livraria
{
    public class Livro
    {
        public string? Isbn {get; set;}

        public string? Descricao {get; set;}

        public Autor? Autor {get; set;}

        public DateTime AnoPublicacao {get; set;}

        public Assunto? Assunto {get; set;}

        public Editora? Editora {get; set;}

        public long? QtdLivro {get; set;}

        public decimal Preco {get; set;} 
    }
}