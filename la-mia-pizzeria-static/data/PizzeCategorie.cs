﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace la_mia_pizzeria_static.data
{
    public class PizzeCategorie
    {
        public Pizze Pizze { get; set; }
        public List<Categoria>? Categorias { get; set; }
        public List<SelectListItem>? Ingredientis { get; set; }
        public List<string>? SelezionaInredienti { get; set; }
    }
}
