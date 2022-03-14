using System;
using DrinkRecipes;


namespace DrinkRecipes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
           
                Console.WriteLine(DateTime.Now.ToString());

                Console.WriteLine("It's 5'oclock here!");

                Console.WriteLine("Login in to access your drink recipes.");

                Console.WriteLine("Please enter your user name: ");

                string userName = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");

                string password = Console.ReadLine();

                Console.WriteLine("Welcome back " + userName + "!");

            

                Console.WriteLine("Would you like to try the recipe of the day? Type yes or no: ");

            bool endapp = false;
            while (!endapp)   //window will stay open until it is closed
            {
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    //to do write method to call random recipe from the api

                    Console.WriteLine("Today's Recipe is " + "-");
                }
            
                else if (answer.ToLower() == "no")
                {

                   


                    
                    Console.WriteLine("You can search by ");   // search by recipe name or ingredient 
                    Console.WriteLine("1. Ingredients");
                    Console.WriteLine("2. Drink Name");

                    string searchBy = Console.ReadLine();

                    if (searchBy == "1")
                    {
                        _ = SearchAPI.SearchByIngredient();     //search by ingredient example: bourbon
                        
                    }
                    else if (searchBy == "2")
                    {
                        _ = SearchAPI.SearchByDrinkName();  //search by drink name

                        
                    }

                    
                }

                else
                {

                    //finish else statement
                    Console.WriteLine("Please enter yes or no to continue: ");
                }
            


            }  
        }
    }
}
