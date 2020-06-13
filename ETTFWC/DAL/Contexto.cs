using ETTFWC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.DAL
{
   

  
    public class Contexto: DbContext
    {

        public DbSet<Estudiante> Students { get; set; }
        public DbSet<Curso> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        //Fluent API configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Estudiante>()
                    .Property(s => s.EstudianteId)
                    .HasColumnName("Id")
                    .HasDefaultValue(0)
                    .IsRequired();
            modelBuilder.Entity<Estudiante>().Property(s => s.EstudianteId).HasColumnName("Id");
            modelBuilder.Entity<Estudiante>().Property(s => s.EstudianteId).HasDefaultValue(0);
            modelBuilder.Entity<Estudiante>().Property(s => s.EstudianteId).IsRequired();

        }
    }
}
