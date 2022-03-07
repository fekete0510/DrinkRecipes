using System;

namespace DrinkRecipes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());

            Console.WriteLine("It's 5'oclock here!");

            Console.WriteLine("Login in to access your drink recipes.");

            Console.WriteLine("Please enter your user name: ");
            
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");  //this information will be saved using an SQL

            string password = Console.ReadLine();

            Console.WriteLine("Welcome back " + userName + "!");

            Console.WriteLine("Would you like to try the recipe of the day? Type yes or no: ");

            bool yes = true;
            bool no = true;

            if (yes == true)
                {
                Console.ReadLine();
                
                Console.WriteLine("Today's Recipe is " + "-"); //there will be a random recipe pulled from the api
            }

            else if (no == true)
            {
                Console.ReadLine();

                Console.WriteLine("You can search for a recipe using the name of a recipe or by ingredients ");
            }

            else
            {
                Console.WriteLine("Please enter yes or no to continue: ");
            }

            

              
        }
    }
}
