using System;
using Cybro;

namespace Chatbot;



class Program
{
    static void Main(string[] args)
    {
        Greeting greeting = new Greeting();
        greeting.audio();
        greeting.welcomeUser();
        string userName = greeting.welcomeUser();
       
        Menu menu = new Menu();
        menu.showMenu(userName);
    }
}

    


