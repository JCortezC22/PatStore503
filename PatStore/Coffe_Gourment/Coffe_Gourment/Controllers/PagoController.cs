using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coffe_Gourment.Models;

namespace Coffe_Gourment.Controllers
{
    public class ProductosVistaController : Controller
    {
        // GET: Pago

        PatStoreEntities db = new PatStoreEntities();


        public ActionResult Index()
        {

            return View(db.Producto.ToList());
        }


    }
}