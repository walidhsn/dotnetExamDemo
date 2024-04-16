using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infra.Configuration
{
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(r => r.vehicule).WithMany(v=>v.reservations).HasForeignKey(r=>r.vehiculeKey);
            builder.HasOne(r => r.locataire).WithMany(l => l.reservations).HasForeignKey(r => r.locataireKey);
            builder.HasKey(r => new {r.dateReservation , r.vehiculeKey, r.locataireKey });
        }
    }
}
