using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

 namespace Livraria{

    [Table("Caixas")]
    public class Caixa
    {
        [Key]
        public long Id {get; set;}

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name="Data do Fechamento")]
        public DateTime DataFechamento {get; set;}

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Total diario do caixa")]
        public decimal? totalDiario {get; set;}

        public Funcionario? Funcionario {get; set;}

    }
} 