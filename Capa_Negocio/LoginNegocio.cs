using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class LoginNegocio
    {
        Login ejecutor = new Login();

        public void InsertarLoginPoster(POSTER loginPoster)
        {
            ejecutor.InsertarLoginPoster(loginPoster);
        }

        public POSTER Comparar(string Nombre_de_Compañia, string Correo_Poster, string Contraseña_Poster)
        {
            return ejecutor.Comparar(Nombre_de_Compañia, Correo_Poster, Contraseña_Poster);
        }
    }
}
