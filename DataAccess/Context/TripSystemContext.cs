using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Entities.Catalogs.Clients;
using Models.Entities.Catalogs.Drivers;
using Models.Entities.Catalogs.Trips;
using Models.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TripSystemContext : IdentityDbContext<ApplicationUser>
    {
        public TripSystemContext(DbContextOptions<TripSystemContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Trip>()
                .HasOne(g => g.Driver)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Trip>()
                .HasOne(g => g.Client)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
