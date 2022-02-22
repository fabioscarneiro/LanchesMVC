using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanches> Lanches { get; }
        IEnumerable<Lanches> LanchesPreferidos { get; }
        Lanches GetLanchesById (int id);

    }
}
