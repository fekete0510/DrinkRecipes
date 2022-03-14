using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

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

        public static async Task<Root> SearchByDrinkName()
        {
            Console.WriteLine("Type in a Drink Name: ");
            string drinkName = Console.ReadLine();

            //www.thecocktaildb.com / api / json / v1 / 1 / search.php ? s = margarita

            HttpResponseMessage response = await client.GetAsync($@"api/json/v1/1/search.php?s={drinkName}");

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;

                Root root = JsonConvert.DeserializeObject<Root>(result);

                return root;
            }
            return null;
        }
    }

}