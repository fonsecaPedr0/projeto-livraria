using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Livraria
 {

    [Table("Compras")]
    public class Compra
    {
        [Key]
        public long codigo {get; set;}

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name="Data-Hora")]
        public DateTime DataHora {get; set;}

        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Total da Compra")]
        public decimal? Total{get; set;}

        [Required]
        [Display(Name = "Preencha o Tipo da Compra")]
        [StringLength(100, ErrorMessage = "Tipo deve ter no maximo 100 caracteres")]
        public string? Tipo {get; set;}

        public Cliente? Cliente {get; set;}

        public Funcionario? Funcionario {get; set;}

        public Caixa? Caixa {get; set;}

        public List<ItemLivro>? ItemLivros {get; set;}

        public List<ItemProduto>? ItemProdutos {get; set;}
        
    }

}
