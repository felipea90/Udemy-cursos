using Lanches.Context;
using Lanches.Models;
using System.Collections.Generic;

namespace Lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contexto;
        public CategoriaRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Categoria> Categorias => _contexto.Categorias;
    }
}
