using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.ComponentModel;

namespace Cybro

{
    class Greeting
    {
        private Menu menu = new Menu();

        public void audio()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer welcome = new SoundPlayer("welcome2cybro.wav");
                welcome.Play();
            }
        }
        public string welcomeUser()
        {
            Console.ResetColor();
            string logo = @"
   __| \ \  / _ )  _ \   _ \  
  (     \  /  _ \    /  (   | 
 \___|   _|  ___/ _|_\ \___/   
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
";
            Console.WriteLine(logo);


            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Hello! and welcome to Cybro. I'm your friendly, trusted cybersecurity companion.", 50);
            Thread.Sleep(2000);
            TypeEffect.Type("\nBefore we begin, what's your name?", 30);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nYou: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nCybro: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            TypeEffect.Type($"Nice to meet you, {userName}! I’m here to help you stay cyber-safe. Chat with me or explore cybersecurity topics!\n", 30);
            Console.ResetColor();

            Thread.Sleep(1000);
            menu.showMenu(userName);

            return userName;
        }
    }
}
