namespace Livraria 
{
    public class ItemProduto 
    {
        public long ItemProdutoId {get; set;}
        
        public long Quantidade {get; set;}

        public virtual Produto Produto {get; set;}
        public int ProdutoId {get; set;}

        public virtual Compra Compra {get; set;}
        public int CompraId {get; set;}
    }
}