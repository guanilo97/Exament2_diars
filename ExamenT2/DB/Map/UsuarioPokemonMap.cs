using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenT2.DB.Map
{
    public class UsuarioPokemonMap : IEntityTypeConfiguration<UsuarioPokemon>
    {
        public void Configure(EntityTypeBuilder<UsuarioPokemon> builder)
        {
            builder.ToTable("UsuarioPokemon");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.pokemon).WithMany(o => o.usuarioPokemons).HasForeignKey(o => o.PokemonId);
        
        }

    }
}
