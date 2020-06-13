using ETTFWC.DAL;
using ETTFWC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ETTFWC
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                //Guardar();
                //Modificar();
                //Consultar();
                //Eliminar();
                //Insertar();
                // ModificarDesconectado();
                // ConsultarLinq();
                 InsertarLinq();
                // ModificarLinq();
                //EliminarLinq();

               
            }
            
            
           
           

        }
        //Guardar
        public static void Guardar()
        {
            
            using (var contexte = new Contexto())
            {
                var std = new Estudiante();
                {
                    std.Nombre= "Steven";
                    std.Apellido = "Nuñez";
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

        //Instertar con Entidad desconectada
        public static void Insertar()
        {
            
            var std = new Estudiante() { Nombre = "Jostin" };

            using (var context = new Contexto())
            {
                context.Add<Estudiante>(std);
                context.SaveChanges();
            }
        }
        //Modificar con entidad desconectada
        public static void ModificarDesconectado()
        {
            var stud = new Estudiante() { EstudianteId = 1, Nombre = "Jostin" };

            stud.Nombre = "Steve";

            using (var context = new Contexto())
            {
                context.Update<Estudiante>(stud);
                context.SaveChanges();
            }
        }
        //Consulta LINQ-to-Entities
        public static void ConsultarLinq()
        {
            using (var context = new Contexto())
            {
                // retrieve entity 
                var student = context.Students.First();
                DisplayStates(context.ChangeTracker.Entries());
            }
        }
        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: { entry.State.ToString()} ");
            }
        }
        //Agregar con Linq-to Entities
        public static void InsertarLinq()
        {
            using (var context = new Contexto())
            {
                context.Add(new Estudiante() { Nombre = "Carlos", Apellido = "Ramirez" });

                DisplayStates(context.ChangeTracker.Entries());
            }
        }
        //Modificar con Linq-to Entities
        public static void ModificarLinq()
        {
            using (var context = new Contexto())
            {
                var estudiante = context.Students.First();
                estudiante.Apellido = "Apellido cambiado";
                DisplayStates(context.ChangeTracker.Entries());
            }

        }
        //Eliminar con Linq-to
        public static void EliminarLinq()
        {
            using (var context = new Contexto())
            {
                var estudiante = context.Students.First();
                context.Students.Remove(estudiante);
                DisplayStates(context.ChangeTracker.Entries());
            }
        }
        //Consulta sin procesar
       /* public static void Consulter()
        {
            string name = "Bill";

            var context = new Contexto();
            var students = context.Students.FromSql("Select * from Students where Name = '{0}'", name)
                                .FromSql("Select * from Students where Name = '{0}'", name)
                                .OrderBy(s => s.StudentId)
                                .ToList();
        }*/
    }

}
