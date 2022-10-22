using Microsoft.AspNetCore.Mvc;
using MySiteWebMVC.Models;

namespace MySiteWebMVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            //Glosario Estanciar e Inicializar
            Product product = new Product()
            {
                Id = 1,
                Name = "Coca Cola",
                Price = 20
            };
            ProductViewModel Viewmodel = new ProductViewModel()
            {
                Title = "Producto",
                Product = product
            };
            //sksks
            ViewBag.active = "products";
            //o
            return View(Viewmodel);
        }
    }
}
