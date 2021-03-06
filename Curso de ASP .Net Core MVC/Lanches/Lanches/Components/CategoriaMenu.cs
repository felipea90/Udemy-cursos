using Lanches.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(
            ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);

            return View(categorias);
        }
    }
}
