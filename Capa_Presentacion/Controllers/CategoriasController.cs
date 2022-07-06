using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class CategoriasController : Controller
    {

        CategoriaNegocio negocio = new CategoriaNegocio();

        // GET: Categorias
        public ActionResult Index()
        {
            return View(negocio.MostrarCategorias());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CATEGORIA1")] CATEGORIA CATEGORIA)
        {
            if (ModelState.IsValid)
            {
                negocio.InsertarCategorias(CATEGORIA);
                return RedirectToAction("Index");
            }

            return View(CATEGORIA);
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (negocio.Edit(id) == null)
            {
                return HttpNotFound();
            }
            return View(negocio.Edit(id));
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,CATEGORIA1")] CATEGORIA CATEGORIA)
        {
            if (ModelState.IsValid)
            {
                negocio.EditarCategoriass(CATEGORIA);
                return RedirectToAction("Index");
            }
            return View(CATEGORIA);
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (negocio.Delete(id) == null)
            {
                return HttpNotFound();
            }
            return View(negocio.Delete(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            negocio.EliminarCategorias(id);
            return RedirectToAction("Index");
        }
    }
}
