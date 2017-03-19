using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.Model
{
    public class FootballContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MatchAtendees> Attendees { get; set; }

        public FootballContext()
        {
            
        }

        public FootballContext(DbContextOptions<FootballContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ds"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchAtendees>().HasKey(x => new{ x.MatchId, x.UserId});

            modelBuilder.Entity<MatchAtendees>().HasOne(u => u.User)
                                                .WithMany(m => m.Matches)
                                                .HasForeignKey(ma => ma.UserId);


            modelBuilder.Entity<MatchAtendees>().HasOne(m=>m.Match)
                                                .WithMany(a => a.Atendees)
                                                .HasForeignKey(ma => ma.MatchId);
        }
    }
}
