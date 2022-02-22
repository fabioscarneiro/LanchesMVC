using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LanchesMacContext _context;

        public CategoriaRepository(LanchesMacContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categoria;
    }
}
