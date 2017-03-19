using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FootballOlimpijski.Model;

namespace FootballOlimpijski.Migrations
{
    [DbContext(typeof(FootballContext))]
    [Migration("20170319162806_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballOlimpijski.Model.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Venue");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("FootballOlimpijski.Model.MatchAtendees", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("UserId");

                    b.HasKey("MatchId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("FootballOlimpijski.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarUrl");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FootballOlimpijski.Model.MatchAtendees", b =>
                {
                    b.HasOne("FootballOlimpijski.Model.Match", "Match")
                        .WithMany("Atendees")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FootballOlimpijski.Model.User", "User")
                        .WithMany("Matches")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
