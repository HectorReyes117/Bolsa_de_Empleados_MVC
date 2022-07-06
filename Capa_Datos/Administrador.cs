using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Administrador
    {
        db_a76d77_bolsadeempleadosEntities db = new db_a76d77_bolsadeempleadosEntities();

        public void InsertarLoginPoster(ADMINISTRADOR loginAdmin)
        {
            db.ADMINISTRADORs.Add(loginAdmin);
            db.SaveChanges();
        }

        public ADMINISTRADOR Comparar(string Correo_Administrador, string Contraseña_Administrador)
        {
            var user = db.ADMINISTRADORs.FirstOrDefault(a => a.Correo_Administrador == Correo_Administrador && a.Contraseña_Administrador == Contraseña_Administrador);
            return user;
        }

       
    }
}
