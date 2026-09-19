using System;
using System.Collections.Generic;

// Stretch challenge: Randomly selecting only those words that are not hidden already
// Exceeding requirements: Programis working with a library of scriptures 
// that are randomly selected.


class Program
{
    static void Main(string[] args)
    {
        
        // creating a library of scriptures
        List<Scripture> library = new List<Scripture>();

        // Adding scriptures to the library
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),"Trust the LORD with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        library.Add(new Scripture(new Reference("John", 14, 1),"Do not let your hearts be troubled. You believe in God; believe also in me ."));
        library.Add(new Scripture(new Reference("2 Nephi", 2, 25),"Adam fell that men might be and men are that they might have joy. "));
        library.Add(new Scripture(new Reference("Mosiah", 2, 17),"When ye are in the service of your fellow beings ye are in the service of your God."));
        library.Add(new Scripture(new Reference("Lamentations", 3, 22, 23),"Because of the Lord's great love we are not consumed, for his compassions never fail. They are new every morning great is his faithfullness."));
        library.Add(new Scripture(new Reference("John", 3, 16),"For god so loved the world that he gave his only begotten son that whosover believeth in him should not perish but have everlasting life."));
        library.Add(new Scripture(new Reference("Psalms", 18, 32),"It is god who arms me with strength and keeps my way secure."));
        library.Add(new Scripture(new Reference("Ecclesiastes", 11, 5),"Whoever watches the wind will not plant; whoever looks at the clouds will not reap."));
        library.Add(new Scripture(new Reference("1 Nephi", 3, 7),"I will go and do the things which the Lord hath commanded."));

        // selecting a random scripture from the library
        Random random = new Random();
        int randomIndex = random.Next(library.Count);
        Scripture scripture = library[randomIndex];
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue ot type 'quit' to finish");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    
    }
}