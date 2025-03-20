using System.Reflection.Emit;

namespace Topic_7___P2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vegetables = new List<string>() {"HORSERADISH", "LETTUCE", "PEA", "RED CABBAGE", "CARROT" };
            string choice = "";
            int indexChoice;
            string vegetableChoice;
            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Topic 7 Part 2's Main Menu! Please select an option to try based on the following list of vegetables: ");
                Console.WriteLine();
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine(i+1 + " - " + vegetables[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Which part of this section would you like to try? ");
                Console.WriteLine("1 - Remove a vegetable by its index");
                Console.WriteLine("2 - Remove a vegetable by its value/name");
                Console.WriteLine("3 - Search for a vegetable"); // state it's index and that it's found
                Console.WriteLine("4 - Add a vegetable");
                Console.WriteLine("5 - Sort the list");
                Console.WriteLine("6 - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                if (choice == "6")
                {
                    Console.WriteLine("You can only select option 4 or quit since you have cleared the list! What is your choice? ");
                    choice = Console.ReadLine().ToLower().Trim();
                    while (choice != "q" && choice != "4")
                    {
                        Console.WriteLine("That's not possible since you cleared the list. Try again!");
                        choice = Console.ReadLine().ToLower().Trim();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    choice = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine();
                }

                if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing! ");
                }
                else
                {
                    if (choice == "1") // remove via index 
                    {
                        Console.WriteLine("You've selected option 1 - Remove a vegetable by its index");
                        Console.WriteLine("What vegetable would you like me to remove? Remember that the index starts at 0 and not 1.");
                        while (!Int32.TryParse(Console.ReadLine(), out indexChoice) || indexChoice == vegetables.Count)
                        {
                            Console.WriteLine($"Incorrect number. You can only remove up to {vegetables.Count - 1}. Try again!");
                        }
                        vegetables.RemoveAt(indexChoice);
                        Console.WriteLine($"The vegetable at index {indexChoice} has been succesfully removed!");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You've selected option 2 - Remove a vegetable by its value/name");
                        Console.WriteLine("What vegetable would you like me to remove? Please tell me the name:");
                        vegetableChoice = Console.ReadLine().ToUpper().Trim();
                        Console.WriteLine();

                        if (vegetables.Contains(vegetableChoice))
                        {
                            vegetables.Remove(vegetableChoice);
                            Console.WriteLine($"The vegetable {vegetableChoice} has been succesfully removed!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"The list does not contain {vegetableChoice} and it was not removed.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("You've selected option 3 - Search for a vegetable");
                        Console.WriteLine("What vegetable should I search for? ");
                        vegetableChoice = Console.ReadLine().ToUpper().Trim();
                        Console.WriteLine();
                        if (vegetables.Contains(vegetableChoice))
                        {
                            Console.WriteLine($"I've found it. {vegetableChoice} is in the list! Its index is {vegetables.IndexOf(vegetableChoice)}.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry! The vegetable {vegetableChoice} does not exist in the list.");
                        }
                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "4") // add a vegetable
                    {
                        Console.WriteLine("You've selected option 4 - Add a vegetable");
                        Console.WriteLine("What vegetable should I add? ");
                        vegetableChoice = Console.ReadLine().ToUpper().Trim();
                        if (vegetables.Contains(vegetableChoice))
                        {
                            Console.WriteLine($"The list already contains {vegetableChoice}. I cannot add duplicates. ");

                        }
                        else
                        {
                            vegetables.Add(vegetableChoice);
                            Console.WriteLine();
                            Console.WriteLine($"The vegetable {vegetableChoice} has been successfully added to the list!");
                            Console.WriteLine();
                        }
                     
                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();
                    }

                    else if (choice == "5") // sort
                    {
                        Console.WriteLine("You've selected option 5 - Sort the list");
                        Console.WriteLine("I will now sort the list! ");
                        vegetables.Sort();
                        Console.WriteLine("Here is the new and improved sorted list: ");
                        Console.WriteLine();
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            Console.WriteLine(i + 1 + " - " + vegetables[i]);
                        }

                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "6") // clear
                    {
                        Console.WriteLine("You've selected option 6 - Clear the list");
                        Console.WriteLine("I will now clear the list! ");
                        vegetables.Clear();
                        Console.WriteLine("The list is now empty,");
                        Console.WriteLine();

                        Console.WriteLine("Press ENTER to return to the main menu!");
                        Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("Invalid choice, press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
