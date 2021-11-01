using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LucasFlix.Models
{
    public class Classificacao : Identity
    {        
        public int ClassificacaoDoFilme { get; set; }

        [NotMapped]
        public string _ClassificacaoDoFilme { get; set; }

        public List<Filme> Filmes { get; set; }
        public List<Serie> Series { get; set; }
    }
}
