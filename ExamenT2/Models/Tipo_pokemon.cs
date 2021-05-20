using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT2.Models
{
    public class Tipo_pokemon
    {
        public int Id { get; set; }
        public string Tipo_nombre { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
