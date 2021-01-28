using Microsoft.EntityFrameworkCore;
using PlanDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanDatabase.Data
{
    public class planDbContext : DbContext
    {
        public planDbContext()
        {

        }

        public planDbContext(DbContextOptions<planDbContext> options):base(options)
        {

        }

        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Plan> Planlar { get; set; }
        public DbSet<Saat> Saatler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>()
                .HasMany(x => x.Planlar)
                .WithOne(y => y.Kisi)
                .HasForeignKey(z => z.KisiId);

            modelBuilder.Entity<Plan>()
                .HasOne(x => x.Saat)
                .WithMany(y => y.Planlar)
                .HasForeignKey(z => z.SaatId);

            modelBuilder.Entity<Plan>()
               .HasOne(x => x.Kisi)
               .WithMany(y => y.Planlar)
               .HasForeignKey(z => z.KisiId);

            modelBuilder.Entity<Saat>()
                .HasMany(x => x.Planlar)
                .WithOne(y => y.Saat)
                .HasForeignKey(z => z.SaatId);

            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB; Database=LadiesOfTurkcell Integrated Security = yes");
            }
        }


    }
}
