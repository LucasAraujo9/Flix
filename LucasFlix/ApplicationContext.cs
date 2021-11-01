using LucasFlix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasFlix
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ator> Ator { get; set; } // tabela Ator 
        public DbSet<Classificacao> Classificacao { get; set; } // tabela Classificacao 
        public DbSet<Diretor> Diretor { get; set; } // tabela Diretor 
        public DbSet<Genero> Genero { get; set; } // tabela Genero 
        public DbSet<Serie> Serie { get; set; } // tabela Serie 
        public DbSet<Filme> Filme { get; set; } // tabela Filme 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FILME
            modelBuilder.Entity<Filme>().HasKey(t => t.Id);
            // SERIE
            modelBuilder.Entity<Serie>().HasKey(t => t.Id);

            // CHAVES PRIMARIAS
            modelBuilder.Entity<Ator>().HasKey(t => t.Id);
            modelBuilder.Entity<Diretor>().HasKey(t => t.Id);
            
            // TESTANDO
            modelBuilder.Entity<Classificacao>();
            modelBuilder.Entity<Genero>();

            // RELAÇÕES 
            modelBuilder.Entity<Filme>().HasOne(t => t.Ator).WithMany(t => t.Filmes);
            modelBuilder.Entity<Serie>().HasOne(t => t.Ator).WithMany(t => t.Series);

            modelBuilder.Entity<Filme>().HasOne(t => t.Diretor).WithMany(t => t.Filmes);
            modelBuilder.Entity<Serie>().HasOne(t => t.Diretor).WithMany(t => t.Series);            
        }

    }
}
