using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            String CharacterName = "John Doe";

            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Please enter your player name: ");
            Console.ReadLine();
            Console.WriteLine("Your name is " + CharacterName);
        }
    }
}
