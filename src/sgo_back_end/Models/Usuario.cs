using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGO_Sistema_de_Gestao_ONGs.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]

        public int  Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }
    }
}
