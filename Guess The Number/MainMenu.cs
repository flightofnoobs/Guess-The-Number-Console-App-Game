using System;

public class MainMenu
{
    Random rnd = new Random();
    public int myNumber = 0;
    public int numberOfAttempts = 0;

    public void TheMainMenu()
    {
        var c2 = new Instruction();

        Console.Clear();
        Console.WriteLine("Guess The Number Game"); // where game starts
        Console.WriteLine("");
        Console.WriteLine("(1) Play");
        Console.WriteLine("(2) Help");
        Console.WriteLine("(3) Exit");
        char selection = Console.ReadKey().KeyChar;

        if (selection == '1')
        {
            DifficultySelect();
        }

        else if (selection == '2')
        {
            c2.InstructionMethod();
        }

        else if (selection == '3')
        {
            
        }

        else
        {
            TheMainMenu();
        }

    }
    public void DifficultySelect()
    {
        var c1 = new Game();

        Console.Clear();
        Console.WriteLine("Select Difficulty");
        Console.WriteLine("");
        Console.WriteLine("(1) Easy");
        Console.WriteLine("(2) Medium");
        Console.WriteLine("(3) Hard");
        Console.WriteLine("(4) Impossible");
        char difficultySelection = Console.ReadKey().KeyChar;

        if (difficultySelection == '1')
        {
            myNumber = rnd.Next(10);
            numberOfAttempts = 3;
            c1.TheGameEasy();
        } 
        else if (difficultySelection == '2')
        {
            myNumber = rnd.Next(0, 100);
            numberOfAttempts = 3;
            c1.TheGameMedium();
        }
        else if (difficultySelection == '3')
        {
            myNumber = rnd.Next(0, 255);
            numberOfAttempts = 5;
            c1.TheGameHard();
        }
        else if (difficultySelection == '4')
        {
            myNumber = rnd.Next(0, 1000);
            numberOfAttempts = 5;
            c1.TheGameImpossible();
        }
        else 
        {
            DifficultySelect();
        }
    }

}
