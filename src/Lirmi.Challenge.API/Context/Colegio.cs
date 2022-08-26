using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lirmi.Challenge.API.Context
{

    [Table("colegio")]
    public class Colegio
    {

        [Key, Required]
        public int id { get; set; }

        public string name { get; set; }
    }
}
