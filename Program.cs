using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string continueChoice;

        do
        {
            Console.Write("Enter the first sentence: ");
            string sentence1 = Console.ReadLine()!;

            Console.Write("Enter the second sentence: ");
            string sentence2 = Console.ReadLine()!;

            
            var words1 = sentence1
                .ToLower()
                .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, 
                       StringSplitOptions.RemoveEmptyEntries);

            var words2 = sentence2
                .ToLower()
                .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, 
                       StringSplitOptions.RemoveEmptyEntries);

            
            bool hasCommonWord = words1.Intersect(words2).Any();

            if (hasCommonWord)
                Console.WriteLine("The substring exists in the string.");
            else
                Console.WriteLine("The substring does not exist in the string.");

            
            do
            {
                Console.Write("Do you want to continue? (y/n): ");
                continueChoice = Console.ReadLine()!.ToLower();

                if (continueChoice != "y" && continueChoice != "n")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (continueChoice != "y" && continueChoice != "n");

        } while (continueChoice == "y");

        Console.WriteLine("Program ended.");
    }
}
