using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("  ");
        Terminal.WriteLine("Press 1 for MARTYS COMPUTER");
        Terminal.WriteLine("Press 2 for POLICE STATION");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("  ");
        Terminal.WriteLine("Enter your selection: ");
    }
    // game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

    void OnUserInput(string input)
    {
        if (input == "menu") // We can always go to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);

        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);

        }

    }

    void RunMainMenu(string input)
    {

        if (input == "1")
        {
            level = 1;
            password = "donkey";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "combobulate";
            StartGame();
        }
        else 
        {
            Terminal.WriteLine("Please Choose Valid Level");
        }
        if (input == "007")
        {
            Terminal.WriteLine("Please Choose a level Mr. Bond");
        }

    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Welcome to Level " + level);
        Terminal.WriteLine("Please Enter Your Password: ");
        }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("WELL DONE!");
        }
        else
        {
            Terminal.WriteLine("Sorry, wrong password!");

        }
    }
}
