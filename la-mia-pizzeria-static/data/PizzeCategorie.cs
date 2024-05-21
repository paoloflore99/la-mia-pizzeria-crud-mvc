namespace la_mia_pizzeria_static.data
{
    public class PizzeCategorie
    {
        public Pizze Pizze { get; set; }
        public List<Categoria>? Categorias { get; set; }
        public List<Ingredienti>? Ingredientis { get; set; }
        public List<string>? SelezionaInredienti { get; set; }
    }
}
