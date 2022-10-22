using Microsoft.AspNetCore.Mvc;
using MySiteWebMVC.Models;

namespace MySiteWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Inicializar
            HomeViewModel Model = new HomeViewModel()
            {
                Title = "MySiteWebMVC | Home",
                Welcome = "Bienvenidos a mi sitio web :3",
                MyDog = "Willup"
            };

            // Instanciar
            HomeViewModel model2 = new HomeViewModel();
            // Inicializar
            model2.Welcome = "Bienvenidos a mi sitio web :3";
            model2.HelloWorld = "Hola mundo :D";

            //Usar en caso necesario
            ViewBag.title = "Este es un VierBag";
            ViewBag.dog = "Willup";
            ViewBag.active = "home";
            //sacdsd        
            return View(Model);

            
        }

        public IActionResult Form()
        {
            FormViewModel form = new FormViewModel()
            {
                Label1 = "Formulario"
            };

            ViewBag.active = "form";

            return View(form);
        }

        public IActionResult DynamicPage()
        {


            DynamicPageViewModel page = new DynamicPageViewModel()
            {
                Title = "Bienvenido",
                home = "Casa"
                
            };

            ViewBag.active = "dynamicpage";

            return View();
        }

        public IActionResult Jquery()
        {
            ViewBag.active = "jquery";

            return View();
        }

        public IActionResult Test()
        {
            ViewBag.active = "test";

            return View();
        }

        public IActionResult Homework()
        {
            ViewBag.active = "homework";

            return View();
        }

        public IActionResult Anectoda()
        {
            ViewBag.active = "anectoda";

            return View();
        }
    }

}
