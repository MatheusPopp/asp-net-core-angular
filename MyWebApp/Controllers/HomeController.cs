using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEmpresaRepository _repository;

        public HomeController(IEmpresaRepository repository) {
            _repository = repository;
        }
        public IActionResult Index() {
            return View();
        }
    }
}
