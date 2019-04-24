//CODE ORGINALLY BELONGS TO UDEMY (Ben Tristem)
//Using code to learn vocab and get used to scripting

using UnityEngine;
public class Hacker : MonoBehaviour
{
    // Game configuration data
    const string menuHint = "You may type menu at any time";
    string[] level1Passwords = { "models", "movies", "NerfGun", "Games", "Digital" };
    string[] level2Passwords = {"Criminals" , "Walkietalkie" , "emergency" , "Jail time"
        , "Uniform"};
    string[] level3Passwords = { "spaceship", "solarsystem", "Astronomy", "Rover", "Jupiter" };
    // Use this for initialization
    void Start()
    {
        print(level1Passwords[0]);
        ShowMainMenu();
    }
    void Update()
    {
        int index = Random.Range(0, level1Passwords.Length);
        print(index);
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
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "007") //Easter Egg
        {
            Terminal.WriteLine("Please Choose a level Mr. Bond");
            Terminal.WriteLine(menuHint);
        }

        else
        {
            Terminal.WriteLine("Please Choose Valid Level");
            Terminal.WriteLine(menuHint);
        }


    }
    void StartGame()
    {
        print(level1Passwords.Length);
        print(level2Passwords.Length);
        print(level3Passwords.Length);
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Level " + level);
        SetRandomPassword();
        Terminal.WriteLine("Enter Your Password, hint: " + password.Anagram());
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                int index2 = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                int index3 = Random.Range(0, level3Passwords.Length);
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invaild Level Number");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            StartGame();

        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }
    void ShowLevelReward()
    {
        switch (level)
        {
             case 1:
                Terminal.WriteLine("WELL DONE!");
                Terminal.WriteLine("Have a Dino!");
                Terminal.WriteLine(@"
               __
              / _)
     _/\/\/\_/ /
   _|         /
 _|  (  | (  |
/__.-'|_|--|_| "

                );
                break;
            case 2:
                Terminal.WriteLine("WELL DONE!");
                Terminal.WriteLine("Have a Police Car!");
                Terminal.WriteLine(@"                        
    _*_ 
 __/_|_\__ 
[(o)_R_(o)]       

"

                );
                break;
            case 3:
                Terminal.WriteLine("WELL DONE!");
                Terminal.WriteLine("Have a Space Ship!");
                Terminal.WriteLine(@"
  /\
 /||\
/:||:\
|:||:|
|/||\|
  **
"

                );
                break;

        }
    }       
}
