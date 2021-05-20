using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.DB;
using ExamenT2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenT2.Controllers
{
    public class PokemonController : Controller
    {
        private IWebHostEnvironment hosting;
        private AppPokemonContext context;

        //private IWebHostEnviromment Hosting;
        public PokemonController(AppPokemonContext context, IWebHostEnvironment hosting)
        {
            this.hosting = hosting;
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.tipos =context.tipo_pokemons.ToList();
            return View(new Pokemon());
        }
        [HttpPost]
        public IActionResult Create(Pokemon pokemon, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                pokemon.Imagen = SaveFile(file);
                context.pokemons.Add(pokemon);
                context.SaveChanges();
                return RedirectToAction("Create");
            }
            ViewBag.tipos = context.tipo_pokemons.ToList();
            return View(pokemon);
        }
        private string SaveFile(IFormFile file)
        {
            string relativePaht = null;
            if (file.Length > 0)
            {
                relativePaht = Path.Combine("files", file.FileName);
                var filePaht = Path.Combine(hosting.WebRootPath, relativePaht);
                var stream = new FileStream(filePaht, FileMode.Create);
                file.CopyTo(stream);
                stream.Close();

            }
            return "/" + relativePaht.Replace('\\', '/');

        }
    }
}
