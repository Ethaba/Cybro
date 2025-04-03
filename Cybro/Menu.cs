using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybro
{
    public class Menu
    {
        private Chat chat = new Chat();
        private Topics topics = new Topics();

        public void showMenu(string userName, string logo)
        {
            bool showMenu = true;

            while (showMenu)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("            CYBRO MAIN MENU            ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Chat with Cybro");
                Console.WriteLine("2. Explore Cybersecurity Topics");
                Console.WriteLine("3. Exit");
                //Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ResetColor();

                while (true) // Inner loop to handle invalid inputs
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nSelect an option: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    string choice = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(choice))
                    {
                        TypeEffect.Type("\nOops! Looks like you didn’t enter anything. Please select a valid option.", 20);
                        TypeEffect.Type("\nPress Enter to try again...", 20);
                        Console.ReadLine(); // Wait for user before clearing the screen
                        continue; // Restart loop
                    }

                    switch (choice)
                    {
                        case "1":
                            //Console.WriteLine("\nLoading chat mode...");
                            Console.Clear();
                            chat.Showchat(userName, logo, this); //Pass 'this' to refer to the current Menu instance
                            break;

                        case "2":
                            Console.Clear();
                            topics.showTopics(userName, logo, this);
                            break;

                        case "3":
                        case "exit":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Thread.Sleep(1000);
                            TypeEffect.Type($"\nSee you later, {userName}! Stay cyber-safe!", 20);
                            Console.ResetColor();
                            TypeEffect.Type($"\nPress any key to exit...", 15);
                            Environment.Exit(0);
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nSorry pal, invalid option. Try again!");
                            Console.ResetColor();
                            continue; // Keep asking for valid input without redrawing the menu
                    }
                    break; // Exit inner loop and refresh menu only after valid input
                }
            }
        }
    }
}

