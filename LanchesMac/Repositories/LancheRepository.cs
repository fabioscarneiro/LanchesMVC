using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly LanchesMacContext _context;
        public LancheRepository(LanchesMacContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanches> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanches> LanchesPreferidos => _context.Lanches.Where(i => i.IsLanchePreferido).Include(c=>c.Categoria);

        public Lanches GetLanchesById(int id)
        {
            return _context.Lanches.FirstOrDefault(x => x.Id == id);
        }
    }
}
