using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lirmi.Challenge.API.Context
{
    [Table("asignatura")]
    public class Asignatura
    {
        [Key, Required]
        public int id { get; set; }

        public string name { get; set; }

        public virtual Curso curso { get; set; } 
    }
}
