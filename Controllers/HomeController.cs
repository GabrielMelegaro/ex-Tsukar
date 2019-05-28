using Microsoft.AspNetCore.Mvc;

namespace Ex.Estacionamento.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}