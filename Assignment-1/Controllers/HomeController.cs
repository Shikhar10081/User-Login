using Microsoft.AspNetCore.Mvc;
using Business_Layer;
using Repo_DB.Model;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
     BL_Function blf= new BL_Function();

        [HttpGet]
        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User use)
        {
            var data = blf.Login(use);

            if (data != null && data.Email == use.Email && data.Password == use.Password)
            {
                HttpContext.Session.SetString("ID", "010");
                return RedirectToAction("Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }
        }

        [HttpGet] 
        public IActionResult Registration()
        {
            string session = HttpContext.Session.GetString("ID");
            if (session != null && session != string.Empty)
            {
                return View();
            }

            return RedirectToAction("Login");

           
        }
        [HttpPost]
        public IActionResult Registration(User use)
        {
             var data = blf.Adddata(use);
            if (data.Equals("Done"))
            {
                TempData["name"] = " Data Save"; 

            }

            return RedirectToAction("Registration");
        }

        [HttpGet]
        public IActionResult Home()
        {
            string session = HttpContext.Session.GetString("ID");
            if (session!=null && session!=string.Empty)
            {
                return View();
            }
           
            return RedirectToAction("Login");
        }

        public IActionResult C_Password()
        {
            string session = HttpContext.Session.GetString("ID");
            if (session != null && session != string.Empty)
            {
                return View();
            }

            return RedirectToAction("Login");
            return View();
        }
    }
}
