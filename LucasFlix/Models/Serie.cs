using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LucasFlix.Models
{
    public class Serie : Identity
    {
        public string NomeDaSerie { get; set; }
        public Ator Ator { get; set; }
        public Diretor Diretor { get; set; }
        public string ClassificacaoIndicativa { get; set; }
        public string GeneroFilme { get; set; }
        //=======================================================
        public Classificacao Classificacao { get; set; }
        public Genero Genero { get; set; }
    }
}
