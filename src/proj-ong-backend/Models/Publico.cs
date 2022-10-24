using System.ComponentModel.DataAnnotations;

namespace proj_ong_backend.Models
{    
    
    public class Publico
    {
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public int telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o telefone.")]
        public string email { get; set; }
    }
}
