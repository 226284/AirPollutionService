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
        public DbSet<PM25> PM25 { get; set; }
        public DbSet<CO> CO { get; set; }
        public DbSet<NO2> NO2 { get; set; }
        public DbSet<NOx> NOx { get; set; }
        public DbSet<PM10> PM10 { get; set; }
        public DbSet<SO2> SO2 { get; set; }
        public DbSet<O3> O3 { get; set; }
        public DbSet<Station> Stations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PollutionData>().ToTable("PollutionData");

            modelBuilder.Entity<Station>()
                .HasOne(s => s.PM25)
                .WithOne(p => p.Station)
                .HasForeignKey<PM25>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.PM10)
                .WithOne(p => p.Station)
                .HasForeignKey<PM10>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.CO)
                .WithOne(p => p.Station)
                .HasForeignKey<CO>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.NO2)
                .WithOne(p => p.Station)
                .HasForeignKey<NO2>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.NOx)
                .WithOne(p => p.Station)
                .HasForeignKey<NOx>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.O3)
                .WithOne(p => p.Station)
                .HasForeignKey<O3>(ad => ad.StationId);
            modelBuilder.Entity<Station>()
                .HasOne(s => s.SO2)
                .WithOne(p => p.Station)
                .HasForeignKey<SO2>(ad => ad.StationId);

            modelBuilder.Entity<Station>()
                .HasMany(s => s.Sensors)
                .WithOne(s => s.Station)
                .HasForeignKey(ad => ad.StationId);
        }
    }
}
