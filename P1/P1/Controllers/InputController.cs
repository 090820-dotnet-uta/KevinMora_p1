using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P1;

namespace P1.Controllers
{
    public class InputController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyUsername(string username)
        {
            if (!DatabaseControl.AccountExists(username))
            {
                return Json($"Username {username} is already in use.");
            }
            return Json(true);
        }
    }
}
