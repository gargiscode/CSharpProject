using System;
using System.Collections.Generic;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a string
            /*
            string name = "Gargi";
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello World!");
            */

            //Two strings
            /*
            string firstFriend = "Shilpa";
            string secondFriend = "Madhuri";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            */

            // String Operations
            /*
            string greeting = "      There are spaces everywhere!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim().Replace("everywhere", "nowhere");
            Console.WriteLine($"[{trimmedGreeting}]");
            */

            //String search
            /*
            string songLyrics = "You say goodbye, and I say hello";
            
            if (songLyrics.StartsWith("You"))
                Console.WriteLine("This sentence starts with You");
            else
                Console.WriteLine("This sentence does not start with You");

            if (songLyrics.EndsWith("hello"))
                Console.WriteLine("This sentence ends with hello");
            else
                Console.WriteLine("This sentence does not end with hello");
            */

            //Integer - Order of operations
            /*
            int a = 5;
            int b = 4;
            int c = 2;
            //int d = a + b * c;
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            */

            //Integer precision and limits
            /*
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"{a+b} divided by {c} equals:");
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            */

            //Integer limits
            /*
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            int whatElse = min + 2;
            Console.WriteLine($"An example of overflow: {what}");
            Console.WriteLine($"An example of overflow: {whatElse}");
            */

            //Working with double type
            /*
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            */

            //Double type precision
            /*
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            */

            //Decimal Type
            /*
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            */

            //Using Math.PI and Math.Pow
            /*
            double radius = 2.50;
            double area = Math.PI * Math.Pow(radius, 2.0);
            Console.WriteLine(Math.PI);
            Console.WriteLine(area);
            */

            //Using if-else
            /*
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            */

            //Difference between do-while and while-do
            /*
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Counter #{counter}");
                counter++;
            }
            Console.WriteLine($"Counter at end of while loop ={counter}");
            Console.WriteLine();

            counter = 0;
            do
            {
                Console.WriteLine($"Counter #{counter}");
                counter++;
            } while (counter < 10);
            Console.WriteLine($"Counter at end of while loop ={counter}");
            */

            //For loop to generate a matrix
            /*
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.Write(column);
                }
                Console.WriteLine();
            }
            */

            //Sum of all integers that are divisible by 4
            /*
            int sum = 0;
            int number;
            for (number = 1; number < 21; number++)
            {
                if (number % 4 == 0)
                {
                    Console.Write($" {number} +");
                    sum = sum + number;
                }
            }
            Console.Write($" = {sum}");
            */

            //Create a List
            /*
            var names = new List<string> { "Gargi", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            */

            //Modify List
            /*
            var cities = new List<string> { "Washington", "Michigan", "North Carolina" };
            Console.WriteLine();
            cities.Add("California");
            cities.Add("Wyoming");
            cities.Remove("Washington");
            foreach (var city in cities)
            {
                Console.WriteLine($" {city.ToUpper()}!");
            }
            Console.WriteLine($"I have visited {cities[0]}.");
            Console.WriteLine($"I have added {cities[2]} and {cities[3]} to the list.");
            Console.WriteLine($"The list has {cities.Count} cities in it");
            */

            // Search and Sort lists
            /*
            var twister = new List<string> { "How", "much", "wood", "could", "a", "wood", "chuck", "chuck", "if", "a", "wood", "chuck", "could", "chuck", "wood?" };
            var index = twister.IndexOf("wood");
            if (index != -1)
                Console.WriteLine($"The word {twister[index]} is at index {index}");

            var notFound = twister.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            twister.Sort();
            foreach (var word in twister)
            {
                Console.WriteLine(word);
            }
            */
        }
    }
}
