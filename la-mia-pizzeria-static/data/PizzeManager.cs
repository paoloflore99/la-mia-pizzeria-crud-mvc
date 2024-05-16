using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.data
{
    public class PizzeManager 
    {

       public static void AggiungoPizze(Pizze pizze)
        {
            using PizzeCintest db = new();
            
                db.Add(pizze);
                db.SaveChanges();
            
        }

        public static List<Pizze> PrendereID(int id)
        {
            return null;
        }
    }


}
