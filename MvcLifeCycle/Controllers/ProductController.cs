using MvcLifeCycle.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RingCentral;
using System.Threading.Tasks;

namespace MvcLifeCycle.Controllers
{
    public class ProductController : Controller
    {
        static readonly IProductRepository repository = new ProductRepository();
        [HttpGet]
        public ActionResult Product()
        {
             return View();
        }

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            //this //
            var listofproducts = repository.GetAll();   
            return Json(listofproducts, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddProduct(ProductVM pd)
        {
            repository.Create(pd);
            return Json(pd, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateProduct(ProductVM pd)
        {          
           repository.Update(pd);
            return Json(repository.GetAll(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            repository.Delete(id);
            return Json(repository.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}