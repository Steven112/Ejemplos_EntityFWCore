using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETTFWC.Models
{
    public partial class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        //Configuraciones
        [Column("Nombre", TypeName = "ntext")]
        [MaxLength(20)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int relacionGradeId { get; set; }
        public Grade Grade { get; set; }

        public IList<EstudianteCurso> estudianteCursos { get; set; }


    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Estudiante> Students { get; set; }
    }


}
