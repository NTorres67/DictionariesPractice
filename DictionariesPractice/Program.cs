using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntax - Dictionary<key data type, value data type> dictionaryName

            //Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            //{
            //    {"Kerry", 90 },  // "Kerry" is the key, 90 is the value
            //    {"Barry", 85 },
            //    {"Michelle", 100}
            //            // ** Be careful as students may have the same name **
            //};

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Snickers" },
            //    {"A2", "Swedish Fish" },
            //    {"A3", "Sour Patch Kids" },
            //    {"A4", "Funyuns" }

            //};

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>(); // ; creates an empty dictionary

            //// Using the Add method, let's add drinks to our drink machine.
            //// This machine used jsut a number to vend an item instead of
            //// a leter-number pair.
            //{
            //    drinkMachine.Add(10, "Ginger Ale");  // 10/key is number on vending machine , "Ginger Ale"/value
            //    drinkMachine.Add(11, "Iced Coffee");
            //    drinkMachine.Add(12, "Water Bottle");
            //    drinkMachine.Add(13, "Sweet Tea");
            //    drinkMachine.Add(14, "Pepsi");
            //    drinkMachine.Add(15, "Mtn Dew");
            //};

            //// Count is a property. Returns the size of the dictionary. == numer of items in the dictionary
            //Console.WriteLine(drinkMachine.Count);
            //Console.WriteLine("");


            //// We have another property called .Key **
            //// ** foreach loop assigns locally
            //// ** drink can be in each location because they are local (belong only to loop they are in)

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key); // ** prints key numbers
            //}
            //Console.WriteLine("");

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Value);
            //}
            //Console.WriteLine("");


            //// Create a dictionary for a theater coat check with 10 elements.
            //// The key will be a number and the value will be the coat style.
            //// Print all the values to the console.

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            //{
            //    coatCheck.Add(20, "black fur coat");
            //    coatCheck.Add(21, "brown leather jacket");
            //    coatCheck.Add(22, "green bomber jacket");
            //    coatCheck.Add(23, "brown leather jacket");
            //    coatCheck.Add(24, "green leather jacket");
            //    coatCheck.Add(25, "brown leather jacket");
            //    coatCheck.Add(26, "brown leather jacket");
            //    coatCheck.Add(27, "brown leather jacket");
            //    coatCheck.Add(28, "brown leather jacket");
            //    coatCheck.Add(29, "brown leather jacket");
            //};

            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat.Value);
            //}
            //Console.WriteLine("");



            //// Create a dictionary for a car valet servie with 10 cars
            //// The key will be the car's last name and the value
            //// will be the car make. Print all key to console

            //Dictionary<string, string> carCheck = new Dictionary<string, string>();
            //{
            //    carCheck.Add("Torres", "Toyota");
            //    carCheck.Add("Bryan", "Subaru");
            //    carCheck.Add("Robey", "Dodge");
            //    carCheck.Add("Javar", "Ford");
            //    carCheck.Add("Smith", "Nissan");
            //    carCheck.Add("Jones", "Isuzu");
            //    carCheck.Add("Kalani", "Chevy");
            //    carCheck.Add("Takaki", "Toyota");
            //    carCheck.Add("Simpson", "Ford");
            //    carCheck.Add("Hinnes", "Toyota");
            //};

            //foreach (KeyValuePair<string, string> car in carCheck)
            //{
            //    Console.WriteLine(car.Key);
            //}
            //Console.WriteLine("");




            // Creat a dictionary of 10 zoo animals. The key will be
            // the animal type and the value will be the number of that
            // animal type at the zoo. Print the animal with the highest
            // quantity at the console.
            // 

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            {
                zooAnimals.Add( "Giraffe", 10 );
                zooAnimals.Add( "Gorilla", 13 );
                zooAnimals.Add( "Chimpanzee", 10 );
                zooAnimals.Add( "Otter", 23 );
                zooAnimals.Add( "Lion", 4 );
                zooAnimals.Add( "Tiger", 5 );
                zooAnimals.Add( "Black Bear", 12 );
                zooAnimals.Add( "Emu", 13 );
                zooAnimals.Add( "Bunny", 678 );
                zooAnimals.Add( "Armadillo", 2 );
            };

            // determine which animal had the highest value

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            //Console.WriteLine(highest);

            foreach (KeyValuePair<string, int> animal in zooAnimals)

                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            Console.WriteLine("");


            // ** HOMEWORK**

            // Remove the zoo animal with the lowest quantity from the 
            // dictionary using the Remove method.
            // Use the Count property to count the number of remaining 
            // entries in the dictionary.
            // Print to the console.

            // Determine which animal hase the lowest quantity

            int lowest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value < highest)
                {
                    lowest = animal.Value;
                }
            }

            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == lowest)
                {
                    Console.WriteLine(animal.Key);
                }
            }

            Console.WriteLine("");

            // Remove the animal wiith the lowest quantity
            //zooAnimals = new Dictionary<string, int>()
            //{
            //    zooAnimals.Remove("Armadillo", 2)
            //};

            zooAnimals.Remove ( "Armadillo", 2 ); // ==========================ISSUE


            //foreach (KeyValuePair<string, int> animal in zooAnimals)
            //{
            //    Console.WriteLine(animal.Value);
            //}


            Console.WriteLine(zooAnimals.Count);

            Console.WriteLine("");
            Console.WriteLine("=================");
            Console.WriteLine("");



            //// ********** HOMEWORK **********

            //// Create a program that allows a user to input an animal 
            //// name to check to see
            //// if the dictionary contains tha animal name.
            //// If the animal does not exist in the dictionary, ask the 
            //// user if he/she would like to add it.
            //// If so, add the animal to the dictionary.

            string userInput;

            Dictionary<string, string> animalNames = new Dictionary<string, string>();
            {
                animalNames.Add("Emmalani", "pet" );
                animalNames.Add("Mana", "pet");
                animalNames.Add("Bina", "pet");
                animalNames.Add("Malia", "pet");
                animalNames.Add("Runty", "pet");
                animalNames.Add("Impy", "pet");
                animalNames.Add("Taryton", "pet");
                animalNames.Add("Girlie", "pet");

            };

            //foreach (KeyValuePair<string, string> name in animalNames)
            //{
            //    Console.WriteLine(name.Key);
            //}

            //// check to see if user input name is in dictionary

            Console.WriteLine("Please enter a pet name.");
            userInput = Console.ReadLine();

            //Console.WriteLine(userInput);

            //// determine if name user inputted is in dictionary


            foreach (KeyValuePair<string, string> name in animalNames)
            {
                if (animalNames.ContainsKey(userInput) == true)
                {
                    Console.WriteLine("The name you listed is already in our list.");
                }
            }

            foreach (KeyValuePair<string, string> name in animalNames)
                if (animalNames.ContainsKey(userInput) == false)
                {
                    Console.WriteLine("Would you like to add the name to the list?");
                }

            // add name to dictionary
            animalNames = new Dictionary<string, string>()
            {
                animalNames.Add(userInput, "pet")
            };



        }
    }
}