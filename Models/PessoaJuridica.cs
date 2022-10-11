using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("PessoaJuridica")]
    public class PessoaJuridica : Pessoa
    {
        [Required(ErrorMessage = "O CNPJ deve ser informado")]
        [MinLength(14, ErrorMessage = "O CNPJ deve ter no minimo {14} caracteres")]
        [MaxLength(18, ErrorMessage = "O CNPJ deve ter no maximo {18} caracteres")]
        [Display(Name="CNPJ")]
        public string? Cnpj {get; set;}
    }
}