namespace Livraria 
{
    public class Pessoa 
    {
        public long Id {get; set;}

        public string? Nome {get; set;}

        public string? Logradouro {get; set;} 

        public string? Bairro {get; set;}

        public string? Numero {get; set;}

        public string? Telefone {get; set;}

        public string? Email {get; set;}

        public Cep? Cep {get; set;}
    }
}