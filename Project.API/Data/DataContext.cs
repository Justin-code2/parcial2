using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Project.Shared.Entities;


namespace Project.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // LLAMAR DE LA BASE DE DATOS Y PONERLO EN PLURAL
        public DbSet<Hack> Hacks { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hack>().HasIndex(c => c.NameHack).IsUnique();
            modelBuilder.Entity<Mentor>().HasIndex(c => c.NameMentor).IsUnique();
            modelBuilder.Entity<Participant>().HasIndex(c => c.NameParti).IsUnique();
            modelBuilder.Entity<Plan>().HasIndex(c => c.NamePro).IsUnique();
            modelBuilder.Entity<Team>().HasIndex(c => c.NameTe).IsUnique();

            //CREACION DE LAS RELACIOES EN API

            //modelBuilder.Entity<Team>()
            //    .HasOne(t => t.Hack)
            //    .WithMany(h => h.Teams)
            //    .HasForeignKey(t => t.HackId)
            //    .OnDelete(DeleteBehavior.Restrict);


            //modelBuilder.Entity<Team>()
            //    .HasOne(t => t.Plan)
            //    .WithOne(p => p.Team)
            //    .HasForeignKey<Plan>(p => p.TeamId);


            //    modelBuilder.Entity<Plan>()
            //        .HasOne(p => p.Team)
            //        .WithOne(t => t.Plan)
            //.       HasForeignKey<Plan>(p => p.TeamId)
            //        .OnDelete(DeleteBehavior.Restrict);

            //    modelBuilder.Entity<Evaluation>()
            //        .HasOne(e => e.Plan)
            //        .WithMany(p => p.Evaluations)
            //        .HasForeignKey(e => e.PlanId)
            //        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}