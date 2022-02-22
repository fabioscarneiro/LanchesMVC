using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Lanches
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo  {1} caracteres")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
