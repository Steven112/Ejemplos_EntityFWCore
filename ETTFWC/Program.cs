using ETTFWC.DAL;
using ETTFWC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace ETTFWC
{
    class Program
    {
        static void Main(string[] args)
        {
            {
               //Guardar
               

               
            }
            
            
           
           

        }
        //Guardar
        public static void Guardar()
        {
            using (var contexte = new Contexto())
            {
                var std = new Estudiante();
                {
                    std.Nombre = "Bill";
                    std.Apellido = "Caceres";
                };
                contexte.Students.Add(std);
                contexte.SaveChanges();
            }
        }
        //Consultar
        public static void Consultar()
        {
            var contexto = new Contexto();
            var studentsWithSameName = contexto.Students.Where(s => s.Nombre == GetNombre()).ToList();
        }
        //Consultar con el nombre de la propiedad
        public static void ConsultaProp()
        {
            var context = new Contexto();

            var studentWithGrade = context.Students
                                    .Where(s => s.Nombre == "Bill")
                                    .Include("Apellido")
                                    .FirstOrDefault();

        }
        public static string GetNombre()
        {
            return "Bill";
        }

        //Modificar
        public static void Modificar()
        {
            using (var context = new Contexto())
            {
                var std = context.Students.First<Estudiante>();
                std.Nombre = "Stiven";
                context.SaveChanges();
            }
        }

        //Eliminar
        public static void Eliminar()
        {
            using (var context = new Contexto())
            {
                var std = context.Students.First<Estudiante>();
                context.Students.Remove(std); 
                context.SaveChanges();
            }
        }
    }
}
