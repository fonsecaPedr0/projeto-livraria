using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Cep")]
    public class Cep : Cidade
    {
        [Key]
        [Required(ErrorMessage = "É necessário informar o numero do CEP")]
        [StringLength(9, ErrorMessage = "O Cep contem {9} Caracteres")]
        [Display(Name = "Numero do Cep")]
        public string? Numero {get; set;}
    }
}