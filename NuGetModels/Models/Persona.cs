using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NuGetModels.Models
{
    [Table("PERSONAS")]
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("APELLIDOS")]
        public String Apellidos { get; set; }
        [Column("DIRECCION")]
        public String Direccion { get; set; }
        [Column("EDAD")]
        public int Edad { get; set; }
    }
}