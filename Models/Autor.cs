using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Autor")]
    public class Autor 
    {
        [Key]
        public long Id {get; set;}

        [Required(ErrorMessage = "É necessário informar o nome do Autor")]
        [StringLength(100, ErrorMessage = "O nome do autor deve conter no maximo 100 caracteres")]
        [Display(Name = "Nome do Autor")]
        public string? Nome {get; set;}
    }
}