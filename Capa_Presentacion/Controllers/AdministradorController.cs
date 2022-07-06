using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Capa_Entidad;
using Capa_Negocio;
using Capa_Datos;
using System.Data.Entity;
using System.Net;

namespace Capa_Presentacion.Controllers
{
    public class AdministradorController : Controller
    {
        AdministradorNegocio negocio = new AdministradorNegocio();
        db_a76d77_bolsadeempleadosEntities db = new db_a76d77_bolsadeempleadosEntities();

        // GET: Login
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Correo_Administrador,string Contraseña_Administrador)
        {
            if (!string.IsNullOrEmpty(Correo_Administrador) && !string.IsNullOrEmpty(Contraseña_Administrador))
            {
                var user = negocio.Comparar(Correo_Administrador, Contraseña_Administrador);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Correo_Administrador, true);
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

        public ActionResult IndexNumero_paginacion()
        {
            List<NUMERO_DE_PAGINACION> numero = db.NUMERO_DE_PAGINACION.ToList();

            return View(numero);
        }

        public ActionResult Edit(int? id)
        {
            NUMERO_DE_PAGINACION NUMERO = db.NUMERO_DE_PAGINACION.Find(id);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (NUMERO == null)
            {
                return HttpNotFound();
            }
            return View(NUMERO);
        }

        // POST: Poster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Numero_de_Paginas")] NUMERO_DE_PAGINACION NUMERO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(NUMERO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexNumero_paginacion");
            }
            return View(NUMERO);
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Poster");
        }
    }
}