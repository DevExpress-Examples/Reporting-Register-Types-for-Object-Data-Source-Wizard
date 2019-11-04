using Microsoft.AspNetCore.Mvc;

namespace ASPNetCore.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
