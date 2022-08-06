//My first training program on C#.
//This program paints all characters from your text in random colors.
//Have fun! :D

using System;

namespace ConsoleApp2 {
    class ColoredText
    {
        static void Main()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            
            Console.WriteLine("Enter any text...");
            String txt = Console.ReadLine();
            
            Console.Clear();
            Console.Write("Your new painted text: ");
            foreach(char character in txt)
            {
                Random rand = new Random();
                Console.ForegroundColor = colors[rand.Next(colors.Length)];
                Console.Write(character);
            }

            Console.ResetColor();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}