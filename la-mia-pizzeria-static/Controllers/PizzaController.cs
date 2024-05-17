using la_mia_pizzeria_static.data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using la_mia_pizzeria_static.data;
namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using PizzeCintest db = new PizzeCintest();
            if (!db.Pizze.Any())
            {
                List<Pizze> PizzaDb = new List<Pizze>()
            {
                new Pizze("Margherita", "suggo, salame, ecc", "~/img/fotopizza.png", 5.90),
                new Pizze("Capricciosa", "suggo, salame, funghi, olive", "~/img/fotopizza.png", 7.50),
                new Pizze("Quattro Stagioni", "suggo, salame, prosciutto cotto, funghi, carciofi", "~/img/fotopizza.png", 8.20),
                new Pizze("Diavola", "suggo, salame piccante, peperoni", "~/img/fotopizza.png", 6.80),
                new Pizze("Quattro Formaggi", "suggo, mozzarella, gorgonzola, fontina, parmigiano", "~/img/fotopizza.png", 9.50),
                new Pizze("Napoli", "suggo, acciughe, olive nere, capperi", "~/img/fotopizza.png", 7.00),
                new Pizze("Vegetariana", "suggo, mozzarella, verdure miste", "~/img/fotopizza.png", 6.50),
                new Pizze("Tonno e Cipolla", "suggo, tonno, cipolla", "~/img/fotopizza.png", 7.20),
                new Pizze("Boscaiola", "suggo, salsiccia, funghi", "~/img/fotopizza.png", 8.00),
                new Pizze("Prosciutto e Funghi", "suggo, prosciutto cotto, funghi", "~/img/fotopizza.png", 7.00)
            };
                foreach (Pizze p in PizzaDb)
                {
                    db.Add(p);
                    db.SaveChanges();

                }
            }

            return View(PizzeManager.ListaPizee() );
        }

        public IActionResult  PerId(int ID)
        {
            return View(PizzeManager.GetPrendere(ID));
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizze pizzeinserita)
        {
            if (!ModelState.IsValid)
            {
                return View(pizzeinserita);
            }

            using (PizzeCintest db = new PizzeCintest())
            {
                db.Add(pizzeinserita);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }

    }
}