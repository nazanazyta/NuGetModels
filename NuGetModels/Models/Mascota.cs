using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NuGetModels.Models
{
    [Table("MASCOTAS")]
    public class Mascota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("RAZA")]
        public String Raza { get; set; }
        [Column("SEXO")]
        public String Sexo { get; set; }
        [Column("EDAD")]
        public int Edad { get; set; }
    }
}