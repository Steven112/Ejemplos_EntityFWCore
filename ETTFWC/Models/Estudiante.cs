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
        public int GradoId { get; set; }
        public Grado Grado { get; set; }

        public Estudiante()
        {
            EstudianteId =0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            FechaNacimiento = DateTime.Now;
            GradoId = 0;
        }
    }
}
