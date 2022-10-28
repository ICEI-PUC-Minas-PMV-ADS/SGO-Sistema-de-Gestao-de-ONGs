using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace sgo_back_end.Models
{
    public class Publico
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
