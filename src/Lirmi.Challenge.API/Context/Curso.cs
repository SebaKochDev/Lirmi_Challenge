using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lirmi.Challenge.API.Context
{
    [Table("curso")]
    public class Curso
    {
        [Key, Required]
        public int id { get; set; }

        public string name { get; set; }

        public virtual Colegio colegio { get; set; }


    }
}
