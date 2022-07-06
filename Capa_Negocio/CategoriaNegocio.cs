using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CategoriaNegocio
    {
        Categorias ejecutor = new Categorias();

        public void InsertarCategorias(CATEGORIA CATEGORIA)
        {
            ejecutor.InsertarCategorias(CATEGORIA);
        }
        public List<CATEGORIA> MostrarCategorias()
        {
            return ejecutor.MostrarCategorias();
        }


        public void EliminarCategorias(int id)
        {
            ejecutor.EliminarCategorias(id);
        }
        public void EditarCategoriass(CATEGORIA CATEGORIA)
        {
            ejecutor.EditarCategoriass(CATEGORIA);
        }
       
        public CATEGORIA Edit(int? id)
        {
            return ejecutor.Edit(id);
        }
        public CATEGORIA Delete(int? id)
        {
            return ejecutor.Delete(id);
        }

        
    }
}
