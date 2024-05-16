using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.data
{
    public class PizzeManager 
    {

        public static Pizze GetPrendere(int id)
        {
            using PizzeCintest db = new PizzeCintest();
            return db.Pizze.FirstOrDefault(x => x.ID == id);
        }

        public static List<Pizze> ListaPizee()
        {
            using PizzeCintest db = new PizzeCintest();
            return db.Pizze.ToList();
        }
    }


}
