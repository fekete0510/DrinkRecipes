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

                Console.WriteLine("Please enter your birthday: ");

                // i want the console to read the birth date entered and then calculate if the person is 21.

            //if the person is 21 than console will say they can proceed
            //else console will say you are not 21 please exit the app.

           /* public static int CalculateAge(DateTime dateOfBirth)
            {
                int age = 0;
                age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age = age - 1;

                return age;
            }*/




            string password = Console.ReadLine();

                Console.WriteLine("Welcome back " + userName + "!");

            

                Console.WriteLine("Would you like to try the recipe of the day? Type yes or no: ");

            //i want the console to show a recipe 
            //currently when yes is entered the app asks for a drink name to be entered 

            bool endapp = false;
            while (!endapp)   //window will stay open until it is closed
            {
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    //to do write method to call random recipe from the api

                    if (answer == "yes")
                    {
                        _ = SearchAPI.RandomRecipeOfTheDay();  //random recipe of the day
                    }


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
