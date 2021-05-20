using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.DB.Map;
using ExamenT2.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenT2.DB
{
    public class AppPokemonContext: DbContext
    {
        public DbSet<Pokemon> pokemons { get; set; }
        public DbSet<UsuarioPokemon> usuariopokemons { get; set; }
        public DbSet<Tipo_pokemon> tipo_pokemons { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public AppPokemonContext(DbContextOptions<AppPokemonContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PokemonMap());
            modelBuilder.ApplyConfiguration(new UsuarioPokemonMap());
            modelBuilder.ApplyConfiguration(new Tipo_pokemonMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}

