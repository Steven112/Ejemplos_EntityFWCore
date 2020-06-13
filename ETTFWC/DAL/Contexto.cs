using ETTFWC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.DAL
{
   

  
    public class Contexto: DbContext
    {

        //Fluent API configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Grade>().HasMany<Estudiante>(g => g.Students).WithOne(s => s.Grade)
                         .HasForeignKey(s => s.relacionGradeId)
                         .OnDelete(DeleteBehavior.Cascade);
            //Relacion de muchos a muchos en API
            modelBuilder.Entity<EstudianteCurso>().HasKey(sc => new { sc.EstudianteId, sc.CursoId });


        }
        public DbSet<Estudiante> Students { get; set; }
        public DbSet<Curso> Courses { get; set; }
        public DbSet<EstudianteCurso> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=A1DB;Trusted_Connection=True;");
        }
    }
}
