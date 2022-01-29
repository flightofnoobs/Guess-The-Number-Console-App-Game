using System;


public class Instruction
{
	public void InstructionMethod()
	{
		var mainMenu = new MainMenu();
		Console.Clear();
		Console.WriteLine("Instructions");
		Console.WriteLine("");
		Console.WriteLine("Select the difficulty then simply guess my number :)))");
		Console.WriteLine("");
		Console.WriteLine("Press Any Key to Continue");
		Console.ReadKey();
	}
}
