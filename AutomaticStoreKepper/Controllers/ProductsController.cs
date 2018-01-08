using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomaticStoreKepper.Controllers
{
    public class ProductsController : Controller
    {
        private BinodISMTEntities db = new BinodISMTEntities();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        // GET: Suppliers/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}