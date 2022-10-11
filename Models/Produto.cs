using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Produto")]
    public class Produto 
    {
        [Key]
        public long Id {get; set;}

        [Required(ErrorMessage = "É necessário informar a descrição do produto")]
        [Display(Name = "Descrição")]
        [StringLength(80)]
        public string? Descricao {get; set;}

        [Display(Name = "Tipo de Produto")]
        [StringLength(50)]
        public string? TipoProduto {get; set;}

        [Required(ErrorMessage = "É necessário informar a quantidade de produtos")]
        [Display(Name = "Quantidade de Produtos")]
        [StringLength(80)]
        public long QtdProduto {get; set;}

        public Fornecedor? Fornecedor {get; set;}

        [Display(Name = "Preço do Produto")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco {get; set;}

    }
}