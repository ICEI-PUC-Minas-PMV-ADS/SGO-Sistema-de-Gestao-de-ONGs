using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sgo_back_end.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório informar o e-mail.")]
        public String? Nome { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        public String? Senha { get; set; }
    }
}