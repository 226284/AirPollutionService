using AirPollution.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Contexts
{
    public class AirPollutionContext: DbContext
    {
        public AirPollutionContext(DbContextOptions<AirPollutionContext> options) : base(options) { }

        public DbSet<PollutionData> Pollutants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PollutionData>().ToTable("PollutionData");
        }
    }
}
