using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class PosterNegocio
    {
        
        Posters ejecutor = new Posters();

        public void InsertarPoster(DATOS_VACANTE VACANTE)
        {
            ejecutor.insertarPoster(VACANTE);
        }
        public List<DATOS_VACANTE> MostrarPoster()
        {
            return ejecutor.MostrarPoster();
        }

        public List<DATOS_VACANTE> MostrarPosterCrud()
        {
            return ejecutor.MostrarPosterCrud();
        }

        public void EliminarPoster(int id)
        {
            ejecutor.EliminarPoster(id);
        }
        public void EditarPoster(DATOS_VACANTE VACANTE)
        {
            ejecutor.EditarPoster(VACANTE);
        }
        public DATOS_VACANTE Detail(int? id)
        {
            return ejecutor.Detail(id);
        }
        public DATOS_VACANTE Edit(int? id)
        {
            return ejecutor.Edit(id);
        }
        public DATOS_VACANTE Delete(int? id)
        {
            return ejecutor.Delete(id);
        }

        public List<CATEGORIA> LLenarDropDownList()
        {
            return ejecutor.LLenarDropDownList();
        }
    }
}
