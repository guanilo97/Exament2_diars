using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.DB;
using ExamenT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamenT2.Controllers
{
    public class CapturarController : Controller
    {
        private AppPokemonContext context;
       
        public CapturarController(AppPokemonContext context)
        {
            
            this.context = context;
        }
        public IActionResult Capturar()
        {
            
            var captura= context.usuariopokemons.Include(o => o.pokemon).Where(o => o.Id_Usuario == getlooged().Id).ToList();
            return View(captura);
        }
        [HttpPost]
        public IActionResult Create(UsuarioPokemon usuarioPokemon)
        {
            usuarioPokemon.Fecha_captura = DateTime.Now;
            var poke = context.pokemons.Where(o => o.Id == usuarioPokemon.PokemonId).First();
            usuarioPokemon.Id_Usuario = getlooged().Id;
            context.usuariopokemons.Add(usuarioPokemon);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Delate(int id)
        {
            var poke = context.usuariopokemons.FirstOrDefault(o => o.Id == id);
            context.usuariopokemons.Remove(poke);
            context.SaveChanges();
            return RedirectToAction("Capturar");

        }
        private Usuario getlooged()
        {
            var claims = HttpContext.User.Claims.First();
            string username = claims.Value;
            var user = context.Usuarios.First(o => o.Username == username);
            return user;
        }
    }
}
