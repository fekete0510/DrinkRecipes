using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DrinkRecipes;

namespace DrinkRecipes
{
    public static class SearchAPI
    {

        public static string apiUrl = "http://www.thecocktaildb.com/";
        public static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(apiUrl)
        };


        public static async Task<Recipe> SearchByIngredient()
        {
            Console.WriteLine("Type in an Ingredient: ");
            string ingredientName = Console.ReadLine();

            //www.thecocktaildb.com/api/json/v1/1/search.php?i=vodka

            HttpResponseMessage response = await client.GetAsync($@"api/json/v1/1/search.php?i={ingredientName}");

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;

                Recipe recipe = JsonConvert.DeserializeObject<Recipe>(result);

                return recipe;
            }
            return null;
        }

    }

}