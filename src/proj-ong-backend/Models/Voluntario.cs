using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_ong_backend.Models
{
    [Table("Doadores")]
    public class Voluntario : Publico
    {
        public string funcao { get; set; }
        public string disponibilidade { get; set; }
    }
}
