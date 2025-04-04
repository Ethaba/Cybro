using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cybro
{
    class Chat
    {
        private Topics Cybertopics = new Topics();
        public void Showchat(string userName, string logo, Menu menu) //passing the menu object to call the showMenu method
        {
            Console.Clear();
            //Display header
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect.Type("Loading chat mode...", 30);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            TypeEffect.Type("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", 1);
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect.Type("                                     Chatting with Cybro!                                     ", 1);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            TypeEffect.Type("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type($"\nIs there anything you'd like to ask me {userName}? (Type 'exit' to return to the main menu)", 20);

            bool chat = true;

            while (chat)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    TypeEffect.Type("\nOops! Looks like you didn’t enter anything. Please type something.", 20);
                    continue;
                }

                switch (input)
                {
                    case "how are you?":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nCybro: ");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        TypeEffect.Type("I’m doing great! Thanks for asking. How about you?", 20);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nYou: ");
                        Console.ForegroundColor = ConsoleColor.White;

                        string response = Console.ReadLine().ToLower();

                        //recognise the mood of the user
                        if (response.Contains("good") || response.Contains("i'm doing good") || response.Contains("i'm fine"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            TypeEffect.Type("\nThat's awesome! A positive mindset is key to staying safe online too.", 20);
                            TypeEffect.Type($"\nAnything else you have in mind {userName}?", 20);
                        }
                        else if (response.Contains("not good") || response.Contains("bad") || response.Contains("i'm not good"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            TypeEffect.Type("\nI'm sorry to hear that. If you ever need a fun cybersecurity fact to cheer you up, let me know!", 20);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            TypeEffect.Type("\nSorry, I do not understand", 20);
                        }
                        break;

                    case "what's your purpose?":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nCybro: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(1000);
                        TypeEffect.Type("My purpose is simple—helping you stay cyber-safe! I can answer questions, share security tips, and guide you through online threats.", 30);
                        break;

                    case "what can i ask about you?":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("\nCybro: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(1000);
                        TypeEffect.Type("I may be a bot, but I’ve got a brain full of cybersecurity knowledge!", 20);
                        TypeEffect.Type("\nYou can ask me about things like strong passwords, phishing, or social engineering.", 20);
                        TypeEffect.Type("\n🔹 Press 1 to open Cybersecurity Topics.", 20);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nYou: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        string topics = Console.ReadLine();

                        if (topics == "1")
                        {
                            Cybertopics.showTopics(userName, logo, menu);
                        }
                        break;

                    case "exit":
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        TypeEffect.Type($"\nIt was great chatting with you, {userName}! Stay cyber-safe!", 20);
                        TypeEffect.Type("\nReturning to the main menu...", 20);
                        Thread.Sleep(2000);
                        chat = false;
                        Console.Clear();
                        Console.WriteLine(logo);
                        menu.showMenu(userName, logo);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Thread.Sleep(1000);
                        TypeEffect.Type("\nOops...I didn’t quite catch that. Try Again please.", 20);
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
