using System;
using System.Collections.Generic;

namespace Lab9Refactoring
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> students = new List<string> { "1. Jimmy Johnson", "2. Tommy Thompson", "3. Bobby Waters", "4. Sally Ride", "5. Bridget Midget" };
            List<string> favFood = new List<string>  { "lasagna", "pizza", "tacos", "ice cream", "cookies" };
            List<string> favTeam = new List<string>  { "Detroit Lions", "Oakland Raiders", "Green Bay Packers", "Minnesota Vikings", "Atlanta Falcons" };
            List<string> favColor = new List<string> { "Red", "Pink", "Blue", "Orange", "Yellow" };
            bool again = true;
            Console.WriteLine("Welcome to the classroom!");

            try
            {
                while (again)
                {

                    Console.WriteLine("Which student would you like to get to know?");



                    foreach (string student in students)
                    {
                        Console.WriteLine(student);

                    }
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "1" || userInput == "jimmy johnson" || userInput == "jimmy")
                    {
                        Console.WriteLine("Would you like to find out Jimmy's favorite food, favorite color, or favorite football team?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "favorite food" || choice == "food" || choice == "fav food" || choice == "1")
                        {
                            Console.WriteLine($"Jimmy's favorite food is {favFood[0]}.");
                        }
                        else if (choice == "favorite football team" || choice == "football" || choice == "football team" || choice == "favorite team" || choice == "fav team" || choice == "team" || choice == "2")
                        {
                            Console.WriteLine($"Jimmy's favorite team is the {favTeam[0]}.");
                        }
                        else if (choice == "color" || choice == "favorite color")
                        {
                            Console.WriteLine($"Jimmy's favorite color is {favColor[0]}.");
                        }
                                        
                        else
                        {
                            Console.WriteLine("That is not a valid response, please try again.");
                            continue;
                        }
                    }
                    else if (userInput == "2" || userInput == "tommy thompson" || userInput == "tommy")
                    {
                        Console.WriteLine("Would you like to find out Tommy's favorite food, favorite color, or favorite football team?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "favorite food" || choice == "food" || choice == "fav food" || choice == "1")
                        {
                            Console.WriteLine($"Tommy's favorite food is {favFood[1]}");
                        }
                        else if (choice == "favorite football team" || choice == "football" || choice == "football team" || choice == "favorite team" || choice == "fav team" || choice == "team" || choice == "2")
                        {
                            Console.WriteLine($"Tommy's favorite team is the {favTeam[1]}");
                        }
                        else if (choice == "color" || choice == "favorite color")
                        {
                            Console.WriteLine($"Jimmy's favorite color is {favColor[1]}.");
                        }


                        else
                        {
                            Console.WriteLine("That is not a valid response, please try again.");
                            continue;
                        }
                    }
                    else if (userInput == "3" || userInput == "bobby waters" || userInput == "bobby")
                    {
                        Console.WriteLine("Would you like to find out Bobby's favorite food, favorite color, or favorite football team?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "favorite food" || choice == "food" || choice == "fav food" || choice == "1")
                        {
                            Console.WriteLine($"Bobby's favorite food is {favFood[2]}");
                        }
                        else if (choice == "favorite football team" || choice == "football" || choice == "football team" || choice == "favorite team" || choice == "fav team" || choice == "team" || choice == "2")
                        {
                            Console.WriteLine($"Bobby's favorite team is the {favTeam[2]}");
                        }
                        else if (choice == "favorite color" || choice == "color")
                        {
                            Console.WriteLine($"Jimmy's favorite color is {favColor[2]}.");
                        }


                           else { 
                            Console.WriteLine("That is not a valid response, please try again.");
                            continue;
                        }
                    }
                    else if (userInput == "4" || userInput == "sally ride" || userInput == "sally")
                    {
                        Console.WriteLine("Would you like to find out Sally's favorite food, favorite color, or favorite football team?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "favorite food" || choice == "food" || choice == "fav food" || choice == "1")
                        {
                            Console.WriteLine($"Sally's favorite food is {favFood[3]}");
                        }
                        else if (choice == "favorite football team" || choice == "football" || choice == "football team" || choice == "favorite team" || choice == "fav team" || choice == "team" || choice == "2")
                        {
                            Console.WriteLine($"Sally's favorite team is the {favTeam[3]}");
                        }
                        else if (choice == "favorite color" || choice == "color")
                        {
                            Console.WriteLine($"Jimmy's favorite color is {favColor[3]}.");
                        }

                        else
                        {
                            Console.WriteLine("That is not a valid response, please try again.");
                            continue;
                        }
                    }
                    else if (userInput == "5" || userInput == "bridget midget" || userInput == "bridget")
                    {
                        Console.WriteLine("Would you like to find out Bridget's favorite food, favorite color, or favorite football team?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "favorite food" || choice == "food" || choice == "fav food" || choice == "1")
                        {
                            Console.WriteLine($"Bridget's favorite food is {favFood[4]}");
                        }
                        else if (choice == "favorite football team" || choice == "football" || choice == "football team" || choice == "favorite team" || choice == "fav team" || choice == "team" || choice == "2")
                        {
                            Console.WriteLine($"Bridget's favorite team is {favTeam[4]}");
                        }
                        else if (choice == "favorite color" || choice == "color")
                            {
                            Console.WriteLine($"Jimmy's favorite color is {favColor[4]}.");
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid response, please try again.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid response, please try again.");
                        continue;
                    }

                    Console.WriteLine("Would you like to find out about another student?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "y")
                    {
                        Console.WriteLine("Have a nice day!");
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"That is not a proper input, {ex.Message}");
            }
        }



    }


}
