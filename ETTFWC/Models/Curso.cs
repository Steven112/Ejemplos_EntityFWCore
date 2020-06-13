using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }
        public IList<EstudianteCurso> estudianteCursos { get; set; }

    }
}
