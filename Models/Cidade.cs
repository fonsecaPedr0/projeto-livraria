using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Cidade")]
    public class Cidade : Uf
    {
        [Key]
        [Required(ErrorMessage = "Informe o código do IBGE")]
        [Display(Name = "Codigo do IBGE")]
        [StringLength(7, ErrorMessage = "O codigo deve conter 7 caracteres")]
        public string? CodIbge {get; set;}
        
        [StringLength(150, ErrorMessage = "O nome da cidade pode conter no maximo 150 caracteres")]
        [Display(Name = "Nome da Cidade")]
        public string? NomeCidade {get; set;}
    }
}