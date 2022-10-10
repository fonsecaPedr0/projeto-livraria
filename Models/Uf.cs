using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Uf")]
    public class Uf 
    {
        [Key]
        [Required(ErrorMessage = "Informe a Sigla do Estado")]
        [Display(Name = "Sigla do estado")]
        [StringLength(2, ErrorMessage = "A sigla deve conter 2 caracteres")]
        public string? Sigla {get; set;}

        [StringLength(150, ErrorMessage = "Nome da Uf deve ter no maximo 150 caracteres")]
        public string? NomeUf {get; set;}
    }
}