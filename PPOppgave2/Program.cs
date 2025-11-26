namespace PPOppgave2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Start:
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
                goto Start;
            }

            Console.WriteLine();
            Console.WriteLine($"What do you wanna know about {chosenUser.Name}?");
            
            Options:
            Console.WriteLine("Options: intro, age, hair, personality, hobbies");
            Console.WriteLine("Type your choice:...");

            string choice = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine();

            if (choice == "intro")
            {
                chosenUser.Introduce();
                Console.WriteLine($"What more do you wanna know about {chosenUser.Name}?");
                goto Options;
            }
            else if (choice == "age")
            {
                Console.WriteLine($"{chosenUser.Name} is {chosenUser.Age} years old.");
                Console.WriteLine($"What more do you wanna know about {chosenUser.Name}?");
                goto Options;
            }
            else if (choice == "hair")
            {
                Console.WriteLine($"{chosenUser.Name}'s hair color is {chosenUser.HairColor}");
                Console.WriteLine($"What more do you wanna know about {chosenUser.Name}?");
                goto Options;
            }
            else if (choice == "personality")
            {
                Console.WriteLine($"{chosenUser.Name}'s personality is/are:  {chosenUser.Personality}");
                Console.WriteLine($"What more do you wanna know about {chosenUser.Name}?");
                goto Options;
            }
            else if (choice == "hobbies")
            {
                Console.WriteLine($"{chosenUser.Name}'s hobbies is/are: {string.Join(", ", chosenUser.Hobbies)}");
                Console.WriteLine($"What more do you wanna know about {chosenUser.Name}?");
                goto Options;
            }
            else
            {
                goto Start;
            }         
            
        }
       
    }
}