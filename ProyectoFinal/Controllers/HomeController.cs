using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Usuarios login)
        {
            if (ModelState.IsValid)
            {
                if (login.checkUser(login.NomUsuario, login.Password))
                {
                    return View("Show", login);
                }
                else
                {
                    ViewBag.Message = "Usuario o password incorrecto";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
    }
}