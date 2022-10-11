using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Assunto")]
    public class Assunto 
    {
        [Key]
        public long Id {get; set;}

        [Required(ErrorMessage = "É necessário informar a descrição do Assunto")]
        [Display( Name = "Descrição")]
        [StringLength(70, ErrorMessage = "A descrição deve conter no máximo 70 caracteres")]
        public string? Descricao {get; set;}
    }
}