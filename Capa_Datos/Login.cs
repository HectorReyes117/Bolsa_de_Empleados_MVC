using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Login
    {
        db_a76d77_bolsadeempleadosEntities db = new db_a76d77_bolsadeempleadosEntities();

        public void InsertarLoginPoster(POSTER loginPoster)
        {
            db.POSTERs.Add(loginPoster);
            db.SaveChanges();
        }

        public POSTER Comparar(string Nombre_de_Compañia, string Correo_Poster, string Contraseña_Poster)
        {
            var user = db.POSTERs.FirstOrDefault(a => a.Nombre_de_Compañia == Nombre_de_Compañia && a.Correo_Poster == Correo_Poster && a.Contraseña_Poster == Contraseña_Poster );
            return user;
        }
    }
}
