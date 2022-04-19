# DrinkRecipes
This project is to find Drink Recipes. Opening the app it will ask you for your name and birthdate.
Since this recipe finder uses alcohol users must be 21 years old. After entering your birth date, the app will either welcome you
by name or the app will close if you are not of age. If you are 21 the app will allow you to continue, welcome you by name and save
your name so that when you use the app in the future it will not ask for you to enter your birthday again.
The app will ask if you would like a random recipe of the day. If the choice is no, it will then prompt you to either chose
to learn about individual liquors of your choice or choose a specific recipe by drink name. 

The features that I chose to use in this project are:
I have a master loop that allows the user to continually use the app with three different options:
1. Search by liquor name, 2. Search by drink name or 3. Exit the app. 

This app uses an API to read data into the app when searched using the different menu options. 
When a recipe is displayed it shows the ingredients and measurements, the glass that it goes in and the instructions 
on how to make the drink.

If a user wants to learn about a specific liquor, it displays information about its origination history and other facts.

This app calculates the users age to ensure that they are 21 years old to use the app. If the user is 21, 
the users name is saved so that they no longer must enter their birthdate when they use the app in the future. 
If the user is under 21, the app gives the user a countdown until their 21st birthday and then closes the app so they are 
not allowed to continue. 
