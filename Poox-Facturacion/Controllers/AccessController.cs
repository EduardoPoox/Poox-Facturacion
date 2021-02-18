using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Poox_Facturacion.Models;

namespace Poox_Facturacion.Controllers
{
    public class AccessController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string email, string password)
        {
            try
            {
                using (facturacionEntities db= new facturacionEntities())
                {
                    var oUser = from d in db.user
                                where d.email == email && d.idState == 1
                                select d;
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error");
            }
        }

    }
}