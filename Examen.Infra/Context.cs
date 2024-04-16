using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
namespace Examen.Infra
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=TunisWalidHsouna;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Configuration.LocataireConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.ReservationConfiguration());
        }
        
        //public void deleteDatabase()
        //{
        //    this.Database.EnsureDeleted();
        //}

        public DbSet<Vehicule> vehicules { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Agent> agents { get; set; }
        public DbSet<Entreprise> entreprisees { get; set;}
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Reservation> reservationes { get; set; }

    }
}
