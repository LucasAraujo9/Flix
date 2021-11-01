using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LucasFlix.Models
{
    public class Genero : Identity
    {
        public string GeneroDoFilme { get; set; }

        public List<Filme> Filmes { get; set; }
        public List<Serie> Series { get; set; }
    }
}
