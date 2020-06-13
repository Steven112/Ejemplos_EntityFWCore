using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.Models
{
    public class Grado
    {
        public int Id { get; set; }
        public string NombreGrado { get; set; }
        public string Seccion { get; set; }

        public ICollection<Estudiante> estudiantes { get; set; }
    }
}
