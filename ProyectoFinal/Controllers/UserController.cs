using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        //Llamado a la vista
        [HttpGet]
        public ActionResult logIn() {

            return View();
        }
        //verificar si los usuarios estan bd
        [HttpPost]
        public ActionResult logIn(UserModel user) {
            if (ModelState.IsValid) {
                if (Isvalid(user.Email, user.Password)) {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(user.Email, false);

                }
            }

            return View(user);
        }
    }
}