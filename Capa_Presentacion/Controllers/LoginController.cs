using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;
using Capa_Datos;
using System.Web.Security;

namespace Capa_Presentacion.Controllers
{
    public class LoginController : Controller
    {
        LoginNegocio negocio = new LoginNegocio();

        // GET: Login
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;           
            return View();
        }

        [HttpPost]     
        public ActionResult Index(string Nombre_de_Compañia, string Correo_Poster, string Contraseña_Poster)
        {
            

            if (!string.IsNullOrEmpty(Nombre_de_Compañia) && !string.IsNullOrEmpty(Correo_Poster) && !string.IsNullOrEmpty(Contraseña_Poster))
            {
                string d = HttpContext.User.Identity.Name;

                var user = negocio.Comparar(Nombre_de_Compañia, Correo_Poster,Contraseña_Poster);
                if (user != null)
                {                   
                    FormsAuthentication.SetAuthCookie(user.Correo_Poster, true);
                    return RedirectToAction("Index", "Poster");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "No encontramos tus datos" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Llena los campos vacios para poder iniciar sesion" });
            }
        }

        public ActionResult Create(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        // POST: Poster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre_de_Compañia,Correo_Poster,Contraseña_Poster,repetir")] string Nombre_de_Compañia,string Correo_Poster, string Contraseña_Poster, string repetir)
        {
            POSTER poster = new POSTER();
            db_a76d77_bolsadeempleadosEntities db = new db_a76d77_bolsadeempleadosEntities();

            var dato = db.POSTERs.ToList();

            foreach (var item in dato)
            {
                 if (item.Nombre_de_Compañia == Nombre_de_Compañia)
                 {
                    return RedirectToAction("Create", new { message = "Ya hay una cuenta vinculada a esta empresa, por favor inicie sesion"});
                }
            }

            foreach (var item in dato)
            {
                if (item.Correo_Poster == Correo_Poster)
                {
                    return RedirectToAction("Create", new { message = "Ya hay una cuenta vinculada a este correo, por favor inicie sesion" });
                }
            }


            if (Contraseña_Poster == repetir && ModelState.IsValid)
            {
                poster.Nombre_de_Compañia = Nombre_de_Compañia;
                poster.Correo_Poster = Correo_Poster;
                poster.Contraseña_Poster = Contraseña_Poster;
                
                negocio.InsertarLoginPoster(poster);
                return RedirectToAction("Index");
            }
       
            else
            {
                return RedirectToAction("Create", new { message = "Las Contraseñas deben coincidir" });              
            }
        }

        public ActionResult MenuInicio()
        {           
            return View();
        }


        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();         
            return RedirectToAction("Index", "Poster");
        }

    }
}