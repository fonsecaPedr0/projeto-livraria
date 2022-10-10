namespace Livraria
{
    public class Produto 
    {
        public long Id {get; set;}

        public string? Descricao {get; set;}

        public string? TipoProduto {get; set;}

        public long QtdProduto {get; set;}

        public Fornecedor? Fornecedor {get; set;}

        public decimal Preco {get; set;}

    }
}