using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LucasFlix.Models
{
    public class Filme : Identity
    {
        public string NomeDoFilme { get; set; }
        public Classificacao Classificacao { get; set; }
        public Genero Genero { get; set; }
        public Ator Ator { get; set; }
        public Diretor Diretor { get; set; }
    }
}
