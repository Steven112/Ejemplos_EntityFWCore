using System;
using System.Collections.Generic;
using System.Text;

namespace ETTFWC.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }

        public Curso()
        {
            CursoId =0;
            NombreCurso = string.Empty;
        }
    }
}
