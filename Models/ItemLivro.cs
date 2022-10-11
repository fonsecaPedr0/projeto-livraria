namespace Livraria
{
    public class ItemLivro
    {
        public long ItemLivroId {get; set;}

        public long Quantidade {get; set;}

        public virtual Livro Livro {get; set;}
        public int LivroId {get; set;}

        public virtual Compra Compra {get; set;}
        public int CompraId {get; set;}
    }
}