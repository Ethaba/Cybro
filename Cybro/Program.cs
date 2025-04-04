using System;
using Cybro;

namespace Chatbot;



class Program
{
    static void Main(string[] args)
    {
        Greeting greeting = new Greeting();
        greeting.audio(); //Play welcome sound
        greeting.welcomeUser(); //Display the logo and welcome message
        string userName = greeting.welcomeUser(); //get the user's name
        string logo = greeting.welcomeUser();
       
        Menu menu = new Menu();
        menu.showMenu(userName, logo); //DIsplay the menu after greeting
    }
}

    


