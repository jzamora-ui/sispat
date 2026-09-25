
using SiPat.Models.Login;
using SiPat.Models.LoginViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SiPat.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View(new login());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["LoginError"] = "El usuario y la contraseña deben tener exactamente 8 caracteres.";
                return View(model);
            }

            var usuario = (model.Usuario ?? "").Trim();
            var contrasena = model.Contrasena ?? "";

            // IMPORTANTE:
            // Sustituye esta llamada por tu validación real contra BD/SP/API.
            // No guardes contraseñas en texto plano.
            bool valido = ValidarCredenciales(usuario, contrasena);

            if (!valido)
            {
                TempData["LoginError"] = "El usuario o la contraseña son incorrectos.";
                return View(model);
            }

            FormsAuthentication.SetAuthCookie(usuario, false);

            return RedirectToAction("Index", "Home");
        }

        private bool ValidarCredenciales(string usuario, string contrasena)
        {
            // EJEMPLO TEMPORAL:
            // return usuario == "USUARIO1" && contrasena == "CLAVE123";
            //
            // Aquí conecta tu SP o servicio de autenticación.
            // Este ejemplo NO debe quedarse en producción.

            return false;
        }

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Login", "Account");
        }
    }
}
