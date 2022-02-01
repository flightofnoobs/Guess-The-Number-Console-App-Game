using System;

public class MainMenu
{
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

        } 
        else if (difficultySelection == '2')
        {

        }
        else if (difficultySelection == '3')
        {

        }
        else if (difficultySelection == '4')
        {

        }
        else 
        {
            DifficultySelect();
        }
    }

}
