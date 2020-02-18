using System.ComponentModel.DataAnnotations;

namespace WebAppTesteDGM.Models
{
    public class ClienteModel
    {
        [Key]
        [Display(Name = "Código do cliente" )]
        public int COD_CLIENTE { get; set; }

        [Required(ErrorMessage = "Nome usual é obrigatório.")]
        [Display(Name = "Nome Usual")]
        public string NOM_USUAL { get; set; }

        [Required(ErrorMessage = "Nome completo é obrigatório.")]
        [Display(Name = "Nome completo")]
        public string NOM_COMPLETO { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório.")]
        [Display(Name = "CPF")]
        public string NRO_CPF { get; set; }

        [Required(ErrorMessage = "Tipo cliente é obrigatório.")]
        [Display(Name = "Tipo de cliente")]
        public int COD_TIPO_CLIENTE { get; set; }

        [Display(Name = "Tipo de cliente")]
        public string DSC_TIPO_CLIENTE { get; set; }

    }
}