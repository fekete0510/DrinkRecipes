using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkRecipes
{
    public class Ingredients
    {
        
            public string idIngredient { get; set; }
            public string strIngredient { get; set; }
            public string strDescription { get; set; }
            public string strType { get; set; }
            public string strAlcohol { get; set; }
            public object strABV { get; set; }
        }

        public class Recipe
        {
            public List<Ingredients> ingredients { get; set; }
        }
    }

