using Microsoft.AspNetCore.Mvc;

namespace D04_MVC_NET_Core.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
