# DrinkRecipes
This project is to find Alcoholic Drink Recipes. The app starts with telling the user the name of the app, the date and time of the app,
and that it is always 5 o'clock in this app. It will first ask you for your name and birth date.
Since this recipe finder uses alcohol, users must be 21 years old. After entering your birth date, the user will either be welcomed
by name or the app will close if you are not of age. If you are 21 it will allow you to continue, welcome you by name and save
your name so that when you use the recipe finder in the future it will not ask for you to enter your birthday again.
The app will ask if you would like a random recipe of the day. If the choice is no, it will show a menu for the user to either chose
to learn about individual liquors of choice, choose a specific recipe by drink name or exit. 

The features that I chose to use in this project are:

There is a  master loop that allows the user to continually get different drink recipes. 
1. Search by liquor name, 2. Search by drink name or 3. Exit the app. 
This can be found on lines 74: to keep app open, Line 135 to Exit the app. 
After the recipe of the day is shown or option 1 or 2 is chosen and shown, the user will have an option to see a random recipe.Line 140
If they chose no they will be brought back the menu where they can search again or exit the console window. 


There is an API to read data into the app when searched using the different menu options. 
Found on line 85 for Random recipes 
Line 113 search by liquor name to learn about its history and other facts
Line 126 search by drink recipe name
A method was used to display the results of the random recipe and the search by drink name Line 161
Method called on Lines 89 and 130



This app calculates the users age to ensure that they are 21 years old to use the app. If the user is 21, 
the users name is saved so that they no longer must enter their birth date when they use the Drink Finder in the future. 
Line 152 Method added to calculate age. 
Called on line 47
Line 243 method added to save user name 
called on line 50

If the user is under 21, the app gives the user a countdown until their 21st birthday
Line 57
and then closes the console window so they are 
not allowed to continue. Line 63


