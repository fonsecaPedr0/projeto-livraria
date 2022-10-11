using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Livraria{

    [Table("Cliente")]
    public class Cliente : PessoaFisica
    {
        [Display(Name="Crédito")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? credito {get; set;}
    }
 }