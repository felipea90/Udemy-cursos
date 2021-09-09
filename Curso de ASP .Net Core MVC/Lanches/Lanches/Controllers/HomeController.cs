using Lanches.Repositories;
using Lanches.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lanches.Controllers
{
    public class HomeController : Controller
    {
        private ILancheRepository _lancheRepository;

        public HomeController(
            ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

         public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }

    }
}
