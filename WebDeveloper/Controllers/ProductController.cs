using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IDataAccess<Product> _product;

        public ProductController(IDataAccess<Product> product)
        {
            _product = product;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}