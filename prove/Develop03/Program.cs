using System;
using System.Collections.Generic;



class Program{

        
        static void Main()
        {
            Scripture scripture = new Scripture("John ", 3, 16, "For God so loved the world, that he gave his only Son, that whoever believes in him shall not perish, but have eternal life. "); 
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
