using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class AdministradorNegocio
    {
        Administrador ejecutor = new Administrador();

        public void InsertarLoginPoster(ADMINISTRADOR loginAdmin)
        {
            ejecutor.InsertarLoginPoster(loginAdmin);
        }

        public ADMINISTRADOR Comparar(string Correo_Administrador, string Contraseña_Administrador)
        {
            return ejecutor.Comparar(Correo_Administrador, Contraseña_Administrador);
        }
    }
}
