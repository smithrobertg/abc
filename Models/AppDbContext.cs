using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<ReadBeforeFlight> ReadBeforeFlights { get; set; }
        public DbSet<Discrepancy> Discrepancies { get; set; }
        public DbSet<Frat> Frats { get; set; }
        public DbSet<StaticFrat> StaticFrats { get; set; }
    }
}
