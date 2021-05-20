using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenT2.DB.Map
{
    public class Tipo_pokemonMap : IEntityTypeConfiguration<Tipo_pokemon>
    {
        public void Configure(EntityTypeBuilder<Tipo_pokemon> builder)
        {
            builder.ToTable("Tipo_pokemon");
            builder.HasKey(o => o.Id);
        }
    }
}
