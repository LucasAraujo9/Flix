using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LucasFlix.Models
{
    public class Ator : Identity
    {        
        public string NomeDoAtor { get; set; }

        public List<Filme> Filmes { get; set; }
        public List<Serie> Series { get; set; }
    }
}
