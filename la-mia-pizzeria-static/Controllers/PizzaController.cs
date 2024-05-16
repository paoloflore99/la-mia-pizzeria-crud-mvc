using la_mia_pizzeria_static.data;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using PizzeCintest db = new PizzeCintest();
            List<Pizze> PizzaDb = new List<Pizze>()
             {
             new Pizze("margherita","suggo , salame, ecc ","~/img/fotopizza.png",5.90) ,
             new Pizze("margherita","suggo , salame, ecc ","~/img/fotopizza.png",5.90),
             new Pizze("margherita","suggo , salame, ecc ","~/img/fotopizza.png",5.90),
            };
            foreach(Pizze p in PizzaDb)
            {
                db.Add(p);
                db.SaveChanges();
            }

            return View("index" );
        }



    }
}