using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sgo_back_end.Models
{
    [Table("Voluntários")]
    public class Voluntario : Publico
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Função")]
        public tipoFuncao Funcao { get; set; }

        [Display(Name = "Disponível esse Mês")]
        public estaDisponivel Disponivel { get; set; }

    }

    public enum tipoFuncao
    {
        Montagem,
        Distribuição
    }
    public enum estaDisponivel
    {
        Sim,
        Não
    }
}
