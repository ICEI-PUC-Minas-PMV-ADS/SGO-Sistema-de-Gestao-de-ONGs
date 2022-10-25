using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sgo_back_end.Models
{
    [Table("Doadores")]
    
    public class Doador : Publico
    {
        [Key]
        public int Id { get; set; }
    }
}
