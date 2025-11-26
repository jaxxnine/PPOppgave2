namespace PPOppgave2 
{
    public class User
    {

        public string Name { get; }
        public int Age { get; }
        public string HairColor { get; }
        public string Personality { get; }
        public string[] Hobbies { get; }

        public User(string name, int age, string hairColor, string personality, string[] hobbies)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
            Personality = personality;
            Hobbies = hobbies;
        }

// public class User
// //{
                //   public string Name { get; set; }
            // public int Age { get; set; }
                //public string HairColor { get; set; }
             //public string Personality { get; set; }
        //public string Hobbies { get; set; }
             //}

    
    
    

        public static User Jon { get; } = new User
          (
            name: "Jon",
            age: 41,
            hairColor: "red",
            personality: "Jovial",
            hobbies: new[] { "gaming" }
          );

    


        public static User Janssen { get; } = new User
        (
            name: "Janssen",
            age: 23,
            hairColor: "black",
            personality: "mixed",
            hobbies: new[] {"gaming","working out","making food"}
        );

        public void Introduce()
        {
            Console.WriteLine($"Heisann! jeg heter {Name} og er {Age} år ung");
        }

        public void ShowHobbies()
        {
            Console.WriteLine($"{Name} sine tidsfordriv er {Hobbies}");
        }
    }
    
}