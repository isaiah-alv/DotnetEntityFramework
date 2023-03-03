using Microsoft.AspNetCore.Mvc;

using alviolai_MVC.Models;

namespace alviolai_MVC.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult IAView()
        {
            return View(uc.IalviolaTables.ToList());
        }
    }
}
