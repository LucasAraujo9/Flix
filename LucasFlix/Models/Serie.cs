using System.ComponentModel.DataAnnotations;

namespace LucasFlix.Models
{
    public class Serie : Identity
    {
        public string NomeDaSerie { get; set; }

        public Ator Ator { get; set; }
        public Classificacao Classificacao { get; set; }
        public Genero Genero { get; set; }
        public Diretor Diretor { get; set; }
    }
}
