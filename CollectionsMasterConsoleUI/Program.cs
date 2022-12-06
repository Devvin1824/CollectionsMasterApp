using System;
using System.Collections.Generic;
using System.Threading;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbersArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbersArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"{numbersArray[0]} is the first number of the array");

            //TODO: Print the last number of the array
            Console.WriteLine($"{numbersArray[numbersArray.Length-1]} is the last number of the array");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbersArray);
            NumberPrinter(numbersArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbersArray);
            
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbersArray);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbersArray);
            NumberPrinter(numbersArray);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbersList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numbersList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numbersList);

            //TODO: Print the new capacity
            NumberPrinter(numbersList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string userNumber; 
            bool valid;
            int result;
            do
            {
                userNumber = Console.ReadLine();
                valid = int.TryParse(userNumber, out result);
                
                if (valid)
                { 
                    NumberChecker(numbersList, result);
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again");
                    
                }
            } while (!valid);
            
           /* Console.WriteLine("What number will you search for in the number list?");
            var userNumber = Console.ReadLine();
            bool valid = int.TryParse(userNumber, out int result);

            if (valid)
            {
                NumberChecker(numbersList, result);
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
           */

            //NumberChecker(numbersList, result);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort();
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var convertList = numbersList.ToArray();

            //TODO: Clear the list
            numbersList.Clear();
            NumberPrinter(numbersList);
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool test = false;
                foreach (var item in numberList)
                {
                    if (searchNumber == item)
                    {
                        Console.WriteLine($"{searchNumber} is in the List");
                        test = true;
                        break;
                    }
                
                }
                if (!test)
                {
                    Console.WriteLine($"{searchNumber} is not in the list");
                }
                
           






        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i <= 50; i++)
            {

                numberList.Add(rng.Next(1, 50));
             
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 50);
                
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }
            NumberPrinter(newArray);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
