using LanchesMac.Models;
using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewsModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanches> Lanches { get; set; }

        [Display(Name = "Categoria Atual")]
        public string CategoriaAtual { get; set; }
    }
}
