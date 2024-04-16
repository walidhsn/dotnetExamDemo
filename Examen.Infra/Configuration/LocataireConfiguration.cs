﻿using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infra.Configuration
{
    public class LocataireConfiguration : IEntityTypeConfiguration<Locataire>
    {
        public void Configure(EntityTypeBuilder<Locataire> builder)
        {
            builder.HasDiscriminator<int>("TypeLocataire")
                .HasValue<Locataire>(0)
                .HasValue<Personne>(1)
                .HasValue<Entreprise>(2);    
        }
    }
}
