using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace sgo_back_end.Models
{
    public class Publico
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string? Nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Obrigatório informar o número de telefone.")]
        public string? Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório informar o e-mail.")]
        public string? Email { get; set; }
    }
}
