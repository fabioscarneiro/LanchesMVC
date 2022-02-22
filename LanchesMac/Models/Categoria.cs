using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [StringLength(100,ErrorMessage= "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        public string  CategoriaNome { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name ="Descrição ")]
        public string Descricao { get; set; }
    }
}
