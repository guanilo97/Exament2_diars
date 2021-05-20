using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.DB;
using ExamenT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ExamenT2.Controllers
{
    public class HomeController : Controller
    {

            private AppPokemonContext context;

            //private IWebHostEnviromment Hosting;
            public HomeController(AppPokemonContext context)
            {
              
                this.context = context;
            }

            public IActionResult Index()
        {
            var pokemon = context.pokemons.Include(o=>o.tipo).ToList();
            return View("Index",pokemon);
        }

    }
}
