using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    [Table("Livro")]
    public class Livro
    {
        [Key]
        public string? Isbn {get; set;}

        [Required(ErrorMessage = "É necessário informar o nome da obra")]
        [Display(Name = "Descrição do Livro")]
        [StringLength(80, ErrorMessage = "A descrição deve ter no máximo 80 caracteres")]
        public string? Descricao {get; set;}

        public Autor? Autor {get; set;}

        [Display(Name = "Ano da publicação")]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Text)]
        public DateTime AnoPublicacao {get; set;}

        public Assunto? Assunto {get; set;}

        public Editora? Editora {get; set;}

        [Required(ErrorMessage = "É necessário informar a quantidade de livros")]
        [Display(Name = "Quantidades de livros")]
        [StringLength(80)]
        public long? QtdLivro {get; set;}

        [Display(Name = "Preço do livro")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco {get; set;} 
    }
}