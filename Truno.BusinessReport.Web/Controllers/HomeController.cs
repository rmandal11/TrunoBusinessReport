using Microsoft.AspNetCore.Mvc;

namespace Truno.BusinessReport.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
