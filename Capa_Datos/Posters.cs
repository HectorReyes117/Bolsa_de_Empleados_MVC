using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Posters
    {
        db_a76d77_bolsadeempleadosEntities db = new db_a76d77_bolsadeempleadosEntities();

        public void insertarPoster(DATOS_VACANTE VACANTE)
        {
            db.DATOS_VACANTE.Add(VACANTE);
            db.SaveChanges();
        }
        public List<DATOS_VACANTE> MostrarPoster()
        {
            return db.DATOS_VACANTE.OrderByDescending(x=> x.id).ToList();
        }

        public List<DATOS_VACANTE> MostrarPosterCrud()
        {
            return db.DATOS_VACANTE.ToList();
        }

        public void EliminarPoster(int id)
        {
            DATOS_VACANTE VACANTE= db.DATOS_VACANTE.Find(id);
            db.DATOS_VACANTE.Remove(VACANTE);
            db.SaveChanges();
        }
        public void EditarPoster(DATOS_VACANTE VACANTE)
        {
            db.Entry(VACANTE).State = EntityState.Modified;
            db.SaveChanges();
        }
        public DATOS_VACANTE Detail(int? id)
        {
            DATOS_VACANTE VACANTE = db.DATOS_VACANTE.Find(id);
            return VACANTE;
        }
        public DATOS_VACANTE Edit(int? id)
        {
            DATOS_VACANTE VACANTE = db.DATOS_VACANTE.Find(id);
            return VACANTE;
        }
        public DATOS_VACANTE Delete(int? id)
        {
            DATOS_VACANTE VACANTE = db.DATOS_VACANTE.Find(id);
            return VACANTE;
        }

        public List<CATEGORIA> LLenarDropDownList()
        {
            List<CATEGORIA> CATEGORIAS = new List<CATEGORIA>();
            CATEGORIAS = db.CATEGORIAS.ToList();
            return CATEGORIAS;
        }
    }
}
