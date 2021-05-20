using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT2.Models
{
    public class UsuarioPokemon
    {
        public int Id { get; set; }
        public int PokemonId {get;set;}
        public int Id_Usuario { get; set; }
        public DateTime Fecha_captura { get; set; }
        public  Pokemon pokemon { get; set; }
    }
}
