using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenT2.DB.Map
{
    public class PokemonMap : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.ToTable("Pokemon");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.tipo).
            WithMany(o=>o.Pokemons).
            HasForeignKey(o=>o.TipoId);
        }
    }
}
