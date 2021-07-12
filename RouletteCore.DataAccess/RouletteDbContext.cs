using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Roulette.DataAccess.Models;

namespace RouletteCore.DataAccess
{
    public class RouletteDbContext: DbContext
    {
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Numbers> Numbers { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<RouletteEvents> RouletteEvents { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserSessions> UserSessions { get; set; }
        public DbSet<UserSessionLog> UserSessionLogs { get; set; }
        public RouletteDbContext(DbContextOptions<RouletteDbContext> options)
        : base(options)
        {


        }

        public RouletteDbContext()
        {

        }


        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseUpdatableEntity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseUpdatableEntity)entityEntry.Entity).UpdateDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseUpdatableEntity)entityEntry.Entity).CreateDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            var str = Environment.GetEnvironmentVariable("RouletteDbContext");

            if (str == null)
            {
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                 .Build();
                str = configuration.GetConnectionString("RouletteDbContext");

            }



            optionsBuilder.UseSqlServer(str);

        }

        internal void RejectChanges()
        {
            throw new NotImplementedException();
        }
    }
}
