using System;

namespace PPOppgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who would you like to know about? (Jon/Janssen)");
            Console.WriteLine("Write a name:");
        
            string input = Console.ReadLine()?.Trim().ToLower();
        
            User chosenUser = null;
        
            if (input == "jon")
            {
                chosenUser = User.Jon;
            }
            else if (input == "janssen")
            {
                chosenUser = User.Janssen;
            }
            else
            {
                Console.WriteLine("Invalid person, try again.");
            return;
            }
        }
    }
}
//