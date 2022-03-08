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
            while (!endapp)
            {
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    //to do write method to call random recipe from the api

                    Console.WriteLine("Today's Recipe is " + "-");
                }
            
                else if (answer.ToLower() == "no")
                {

                    //name or ingredient 


                    
                    Console.WriteLine("You can search by ");
                    Console.WriteLine("1. Ingredients");
                    Console.WriteLine("2. Recipe Name");

                    string searchBy = Console.ReadLine();

                    if (searchBy == "1")
                    {
                        SearchAPI.SearchByIngredient();
                    }
                    else if (searchBy == "2")
                    {
                        //SearchByName();
                    }

                    //finish else statement
                }

                else
                {
                    Console.WriteLine("Please enter yes or no to continue: ");
                }
            


            }  
        }
    }
}
