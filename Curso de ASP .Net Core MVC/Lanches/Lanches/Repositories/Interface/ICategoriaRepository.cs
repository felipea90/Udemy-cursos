using Lanches.Models;
using System.Collections.Generic;

namespace Lanches.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
