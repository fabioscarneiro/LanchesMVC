using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewsModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;

            return View(lanchesListViewModel);
        }
    }
}
