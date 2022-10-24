using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_ong_backend.Models
{

    [Table("Doadores")]
    [Keyless]
    public class Doador : Publico
    {
    }
}
