using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT2.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ("campo es obligatorio"))]
        public string Nombre { get; set; }
        [Required(ErrorMessage = ("campo es obligatorio"))]
        public  int TipoId { get; set; }
        [Required(ErrorMessage = ("campo es obligatorio"))]
        public string Imagen { get; set; }
        public Tipo_pokemon tipo { get; set; }
        public List<UsuarioPokemon> usuarioPokemons { get;set; }
    }
}
