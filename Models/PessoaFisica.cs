using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Livraria{

    [Table("PessoaFisicas")]
    public class PessoaFisica : Pessoa
    {  
        [Required(ErrorMessage = "O CPF deve ser informado")]
        [MinLength(11, ErrorMessage = "O CPF deve ter no minimo {11} caracteres")]
        [MaxLength(14, ErrorMessage = "O CPF deve ter no maximo {14} caracteres")]
        [Display(Name="CPF")]
        public string? Cpf {get; set;}

    }

 }