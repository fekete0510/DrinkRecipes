﻿using System;
using System.Threading.Tasks;
using DrinkRecipes;
using System.IO;



namespace DrinkRecipes
{
    public class Program
    {

        public static async Task Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("***********************");

            Console.WriteLine("It's 5'oclock here!");
            Console.WriteLine("***********************");

            Console.WriteLine("Let's find some drinks!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name: ");

            string userName = Console.ReadLine();


            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, userName))) //if name has been entered with birth date over 21
                                                                                            //in the console before it has been saved and person will not have to
                                                                                            //enter birth date in again. 
            {
                Console.WriteLine("Welcome back " + userName); 

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
                    Console.WriteLine("You are underage please exit this drink finder.");
                    Environment.Exit(0);  //Console will close if birth date entered is less than 21 years old
                }

            }

            

            

            Console.WriteLine("Would you like to try the recipe of the day? Type yes or no: ");

           
            

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





                    Console.WriteLine("You can learn about different types of liquors or find a specific drink recipe. Choose Option 1 or 2: ");   // search by recipe name or ingredient 
                    Console.WriteLine("1. Search by Liquor name: ");
                    Console.WriteLine("2. Recipe by Drink Name");

                    string searchBy = Console.ReadLine();

                    if (searchBy == "1")
                    {
                        IngredientName ingredientName = await SearchAPI.SearchByIngredient();     //search by ingredient example: bourbon

                        Console.WriteLine();

                        Console.WriteLine(ingredientName.ingredients[0].strDescription);

                    }
                    else if (searchBy == "2")
                    {
                        DrinkName drinkName = await SearchAPI.SearchByDrinkName();  //search by specific drink name example: margarita

                        Console.WriteLine();

                        ShowRecipeInstructions(drinkName);




                    }


                }

                else
                {

                   
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

            Console.WriteLine();
            Console.WriteLine(drinkName.drinks[0].strInstructions);

        }

        public static void SaveName(string fileName)
        {
            File.WriteAllText(fileName, "");




        }
    }
}

/* to do list
 * make ingredients and measurements look nicer
 * close app when person is not 21
 * make text file to save name and birth date so users over 21 can enter without re entering birth date
 */



