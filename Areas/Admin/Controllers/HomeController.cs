using Microsoft.AspNetCore.Mvc;
using shunshine.App.ApplicationServices.ServiceInterfaces;

namespace shunshine.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}