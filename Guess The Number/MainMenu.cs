using System;

public class MainMenu
{
    public void TheMainMenu()
    {
        var c2 = new Instruction();
        var c1 = "na";
        Console.Clear();
        Console.WriteLine("Guess The Number Game"); // where game starts
        Console.WriteLine("");
        Console.WriteLine("(1) Play");
        Console.WriteLine("(2) Help");
        Console.WriteLine("(3) Exit");
        char selection = Console.ReadKey().KeyChar;

        if (selection == '1')
        {

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
}
