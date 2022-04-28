using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KatmanliMimari.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari2.UI.Controllers
{
    public class ProductsController : Controller
    {
        readonly IProductsBusiness _proBus;
        public ProductsController(IProductsBusiness proBus)
        {
            _proBus = proBus;
        }
        public IActionResult List()
        {
            var plist = _proBus.GetProducts();
            return View(plist);
        }
    }
}
