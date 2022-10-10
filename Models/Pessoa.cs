using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria 
{
    [Table("Pessoa")]
    public class Pessoa 
    {
        [Key]
        public long Id {get; set;}

        [Required(ErrorMessage = "Deve ser informado o nome")]
        [Display(Name =  "Informe o nome")]
        [StringLength(150, ErrorMessage = "O nome deve conter no máximo")]
        public string? Nome {get; set;}

        [StringLength(100, ErrorMessage = "O lagradouro deve conter no máximo 100 caracteres")]
        [Display(Name = "Informe o logradouro")]
        public string? Logradouro {get; set;} 

        [StringLength(50, ErrorMessage = "O bairro deve conter no máximo 50 caracteres")]
        [Display(Name = "Informe o bairro")]
        public string? Bairro {get; set;}

        [StringLength(5, ErrorMessage = "O numero pode conter no máximo 5 digitos")]
        [Display(Name = "Informe o numero")]
        public string? Numero {get; set;}

        public string? Telefone {get; set;}

        [Required(ErrorMessage = "É necessário informar o email para realizar o cadastro")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [Display(Name = "Informe o Email")]
        public string? Email {get; set;}

        public Cep? Cep {get; set;}
    }
}