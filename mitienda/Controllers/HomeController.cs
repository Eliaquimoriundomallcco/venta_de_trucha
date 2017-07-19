using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mitienda.Controllers
{
    public class HomeController : Controller


    {

        private Models.mitiendaEntities bd = new Models.mitiendaEntities();


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(String id = "")
        {
            //logica de acceso a bd

            var productos = bd.Producto.Where(X => X.Descripcion.Contains(id)).Take(12).ToList();

            //lista de productos
            ViewBag.buscar = id;
            return View(productos);
          

        }

      
    }
}