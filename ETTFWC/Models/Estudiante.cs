using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.Models
{
    public partial class Estudiante
    {
        

        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Estudiante()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
    }
}
