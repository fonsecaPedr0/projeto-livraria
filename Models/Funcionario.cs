 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Livraria{

    [Table("Funcionario")]
    public class Funcionario : PessoaFisica
    {
        [Required]
        [Display(Name = "Preencha o Cargo")]
        [StringLength(100, ErrorMessage = "Cargo deve ter no maximo 100 caracteres")]
        public string? Cargo {get; set;}

        [Display(Name="Sálario")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Salario {get; set;}
    }

 }