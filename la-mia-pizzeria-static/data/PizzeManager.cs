using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.data
{
    public class PizzeManager 
    {

        public static Pizze GetPrendere(int id, bool IncludiCategoria=true)
        {
            using PizzeCintest db = new PizzeCintest();
            //return db.Pizze.FirstOrDefault(x => x.ID == id);
            if (!IncludiCategoria)
            {
                return db.Pizze.FirstOrDefault(x => x.ID == id);
            }
            else
            {
                return db.Pizze.Where(x => x.ID == id).Include(c => c.Categoria).FirstOrDefault();
            }

        }
        


        
        public static List<Pizze> ListaPizee()
        {
            using PizzeCintest db = new PizzeCintest();
            return db.Pizze.ToList();
        }


    }


}
