using System;
using System.Threading.Tasks;
using DrinkRecipes;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;



namespace DrinkRecipes
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Drink Finder!");
            Console.WriteLine();
            Console.WriteLine("Today's Date and time  is: " + DateTime.Now.ToString());
            Console.WriteLine("***********************************************");

            Console.WriteLine("But it's 5'oclock here!");
            Console.WriteLine("************************");

            Console.WriteLine("Let's find some drinks.");
            Console.WriteLine();
            Console.WriteLine("Please enter your name: ");

            string userName = Console.ReadLine();


            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, userName))) //if name has been entered with birth date over 21
                                                                                            //in the console before it has been saved and person will not have to
                                                                                            //enter birth date in again. 
            {
                Console.WriteLine("Welcome back " + userName + "!"); 

            }

            else
            {
                Console.WriteLine("Please enter your birthday: ");

                string birthdate = Console.ReadLine();

                DateTime datetime = DateTime.Parse(birthdate); 


                if (CalculateYears(datetime) > 21)
                {
                    SaveName(userName); //name entered is saved if birth date is over 21 
                    Console.WriteLine("You are over 21 you may continue!");
                }
                else
                {
                    TimeSpan t = DateTime.Now - DateTime.Parse(birthdate);  //countdown from todays date until user is 21
                    string output = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds",
                        t.Days, t.Hours, t.Minutes, t.Seconds);

                    Console.WriteLine(userName + " You have this long until you are 21:  " + output);
                    Console.WriteLine("You are underage please exit this drink finder.");
                    Environment.Exit(0);  //Console will close if birth date entered is less than 21 years old
                }

            }
            

            Console.WriteLine("Would you like to try a random recipe? Type yes or no : ");

           
            

            bool endapp = false;
            while (!endapp)   //window will stay open until it is closed
            {
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    

                    if (answer == "yes")
                    {
                        DrinkName drinkName = await SearchAPI.RandomRecipeOfTheDay();  //random recipe of the day

                        Console.WriteLine();

                        ShowRecipeInstructions(drinkName);


                        
                    }
                    
                }

                else if (answer.ToLower() == "no")
                {





                    Console.WriteLine("You can learn about different types of liquors or find a specific drink recipe. Choose Option 1, 2 or 3: ");   // search by recipe name or ingredient 
                    Console.WriteLine("1. Search by Liquor name. Example: Bourbon ");
                    Console.WriteLine("2. Recipe by Drink Name. Example: Margarita or French 75");
                    Console.WriteLine("3. Exit App");

                    string searchBy = Console.ReadLine();

                    if (searchBy == "1")
                    {
                        IngredientName ingredientName = await SearchAPI.SearchByIngredient();     //search by ingredient example: bourbon

                        Console.WriteLine();

                        Console.WriteLine(ingredientName.ingredients[0].strDescription);

                        Console.WriteLine();

                        Console.WriteLine("Please press enter to continue.");

                    }
                    else if (searchBy == "2")
                    {
                        DrinkName drinkName = await SearchAPI.SearchByDrinkName();  //search by specific drink name example: margarita

                        Console.WriteLine();

                        ShowRecipeInstructions(drinkName);
                       
                    }
                    else if(searchBy == "3")
                    {
                        Environment.Exit(0);
                    }

                }

                else
                {
                  
                    Console.WriteLine("Would you like to try a random recipe? Please enter yes or no to continue: ");
                }



            }


        }
        public static int CalculateYears(DateTime birthDate)
        {
            DateTime now = DateTime.Today;

            int age = now.Year - birthDate.Year;  //starts by calculating year 

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) //then checks the birth month against current month then checks the birth date against current date 
                age--;

            return age;
        }


        public static void ShowRecipeInstructions(DrinkName drinkName)
        {
            Console.WriteLine(drinkName.drinks[0].strDrink);
            
            Console.WriteLine();              
            
            Console.WriteLine(drinkName.drinks[0].strGlass);

            Console.WriteLine();

            if (drinkName.drinks[0].strIngredient1 != null) 
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient1 + " -- " + drinkName.drinks[0].strMeasure1);
            }

            if (drinkName.drinks[0].strIngredient2 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient2 + " -- " + drinkName.drinks[0].strMeasure2);
            }
            if (drinkName.drinks[0].strIngredient3 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient3 + " -- " + drinkName.drinks[0].strMeasure3);
            }
            if (drinkName.drinks[0].strIngredient4 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient4 + " -- " + drinkName.drinks[0].strMeasure4);
            }
            if (drinkName.drinks[0].strIngredient5 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient5 + " -- " + drinkName.drinks[0].strMeasure5);
            }
            if (drinkName.drinks[0].strIngredient6 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient6 + " -- " + drinkName.drinks[0].strMeasure6);
            }
            if (drinkName.drinks[0].strIngredient7 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient7 + " -- " + drinkName.drinks[0].strMeasure7);
            }
            if (drinkName.drinks[0].strIngredient8 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient8 + " -- " + drinkName.drinks[0].strMeasure8);
            }
            if (drinkName.drinks[0].strIngredient9 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient9 + " -- " + drinkName.drinks[0].strMeasure9);
            }
            if (drinkName.drinks[0].strIngredient10 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient10 + " -- " + drinkName.drinks[0].strMeasure10);
            }
            if (drinkName.drinks[0].strIngredient11 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient11 + " -- " + drinkName.drinks[0].strMeasure11);
            }
            if (drinkName.drinks[0].strIngredient12 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient12 + " -- " + drinkName.drinks[0].strMeasure12);
            }
            if (drinkName.drinks[0].strIngredient13 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient13 + " -- " + drinkName.drinks[0].strMeasure13);
            }
            if (drinkName.drinks[0].strIngredient14 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient14 + " -- " + drinkName.drinks[0].strMeasure14);
            }
            if (drinkName.drinks[0].strIngredient15 != null)
            {
                Console.WriteLine("* " + drinkName.drinks[0].strIngredient15 + " -- " + drinkName.drinks[0].strMeasure15);
            }

            Console.WriteLine();
            Console.WriteLine(drinkName.drinks[0].strInstructions);
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue.");
        }

        public static void SaveName(string fileName)
        {
            File.WriteAllText(fileName, "");
        }
      



    }
}





