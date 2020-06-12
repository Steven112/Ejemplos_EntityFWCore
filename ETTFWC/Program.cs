using ETTFWC.DAL;
using ETTFWC.Models;
using System;

namespace ETTFWC
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                using (var context = new Contexto())
                {
                    var std = new Estudiante();
                    {
                        std.Nombre = "Bill";
                        std.Apellido = "Caceres";
                    };
                    context.Students.Add(std);
                    context.SaveChanges();
                }
            }
        }
    }
}
