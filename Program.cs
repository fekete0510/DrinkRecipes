using System;
using System.Threading.Tasks;
using DrinkRecipes;


namespace DrinkRecipes
{
    public class Program
    {

        public static async Task Main(string[] args)
        {


            Console.WriteLine(DateTime.Now.ToString());

            Console.WriteLine("It's 5'oclock here!");

            Console.WriteLine("Login in to access your drink recipes.");

            Console.WriteLine("Please enter your user name: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your birthday: ");

            string birthdate = Console.ReadLine();

            DateTime datetime = DateTime.Parse(birthdate); //convert lookup

            if (CalculateYears(datetime) > 21)
                Console.WriteLine("You are over 21 you may continue!");
            else
                Console.WriteLine("You are underage please exit this drink finder.");





            // i want the console to read the birth date entered and then calculate if the person is 21.

            //if the person is 21 than console will say they can proceed
            //else console will say you are not 21 please exit the app.






            string password = Console.ReadLine();

            Console.WriteLine("Welcome " + userName + "!");



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
                        DrinkName drinkName = await SearchAPI.RandomRecipeOfTheDay();  //random recipe of the day

                        ShowRecipeInstructions(drinkName);

                        //write if statement to show measurements if recipe has a blank spot  
                    }
                    // make it look the way i want to 
                }

                else if (answer.ToLower() == "no")
                {





                    Console.WriteLine("You can learn about different types of liquors or find a drink recipe. Choose Option 1 or 2: ");   // search by recipe name or ingredient 
                    Console.WriteLine("1. Search by Liquor name: ");
                    Console.WriteLine("2. Recipe by Drink Name");

                    string searchBy = Console.ReadLine();

                    if (searchBy == "1")
                    {
                        IngredientName ingredientName = await SearchAPI.SearchByIngredient();     //search by ingredient example: bourbon
                        Console.WriteLine(ingredientName.ingredients[0].strDescription);

                    }
                    else if (searchBy == "2")
                    {
                        DrinkName drinkName = await SearchAPI.SearchByDrinkName();  //search by drink name

                        ShowRecipeInstructions(drinkName);




                    }


                }

                else
                {

                    //finish else statement
                    Console.WriteLine("Would you like to try a recipe of the day? Please enter yes or no to continue: ");
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
            Console.WriteLine(drinkName.drinks[0].strIngredient1  +  drinkName.drinks[0].strMeasure1);
            Console.WriteLine(drinkName.drinks[0].strIngredient2 + drinkName.drinks[0].strMeasure2);
            Console.WriteLine(drinkName.drinks[0].strIngredient3 + drinkName.drinks[0].strMeasure3);
            Console.WriteLine(drinkName.drinks[0].strIngredient4 + drinkName.drinks[0].strMeasure4);
            Console.WriteLine(drinkName.drinks[0].strIngredient5 + drinkName.drinks[0].strMeasure5);
            Console.WriteLine(drinkName.drinks[0].strIngredient6 + drinkName.drinks[0].strMeasure6);
            Console.WriteLine(drinkName.drinks[0].strIngredient7 + drinkName.drinks[0].strMeasure7);
            //Console.WriteLine(drinkName.drinks[0].strIngredient8 + drinkName.drinks[0].strMeasure8);
            //Console.WriteLine(drinkName.drinks[0].strIngredient9 + drinkName.drinks[0].strMeasure9);
           
            Console.WriteLine(drinkName.drinks[0].strInstructions);

        }






    }
}

/* to do list
 * make ingredients and measurements look nicer
 * close app when person is not 21
 * make text file to save name and birth date so users over 21 can enter without re entering birth date
 */



