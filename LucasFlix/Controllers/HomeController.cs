using LucasFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LucasFlix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _contexto;

        public HomeController( ApplicationContext contexto)
        {
            _contexto = contexto;
        }

        //=================TelaInicial=======================================================================
        public IActionResult TelaInicial()
        {
            return View();
        }

        //=================CadastroFilme=======================================================================
        public IActionResult CadastroFilme()
        {            
            ViewBag.Filme = new SelectList(_contexto.Filme.ToList(), "Id", "Filme");
            ViewBag.Ator = new SelectList(_contexto.Ator.ToList(), "Id", "NomeDoAtor");
            ViewBag.Genero = new SelectList(_contexto.Genero.ToList(), "Id", "Genero");
            ViewBag.Diretor = new SelectList(_contexto.Diretor.ToList(), "Id", "Diretor");
            ViewBag.Classificacao = new SelectList(_contexto.Classificacao.ToList(), "Id", "ClassificacaoDoFilme");

            return View();
        }

        
        public IActionResult _CadastroFilme(Filme filme)
        {
            _contexto.Add(filme);
            _contexto.SaveChanges();

            return View("TelaInicial");            
        }

        //================CadastroSerie========================================================================

        public IActionResult CadastroSerie()
        {
            ViewBag.Serie = new SelectList(_contexto.Serie.ToList(), "Id", "Serie");
            ViewBag.Ator = new SelectList(_contexto.Ator.ToList(), "Id", "NomeDoAtor");
            ViewBag.Genero = new SelectList(_contexto.Genero.ToList(), "Id", "Genero");
            ViewBag.Diretor = new SelectList(_contexto.Diretor.ToList(), "Id", "Diretor");
            ViewBag.Classificacao = new SelectList(_contexto.Classificacao.ToList(), "Id", "ClassificacaoDoFilme");

            return View();
        }

        public IActionResult _CadastroSerie(Serie serie)
        {
            _contexto.Add(serie);
            _contexto.SaveChanges();

            return View("TelaInicial");
        }

        //========================================================================================


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
