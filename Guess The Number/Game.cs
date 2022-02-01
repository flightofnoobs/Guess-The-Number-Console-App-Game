using System;

public class Game
{
	public int theNumber = 0;
	Random rnd = new Random();

	public void TheGameEasy()
	{
		Console.WriteLine("Guess my Number from 0-10");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("Attempts Left: ");

	}
	public void TheGameMedium()
	{
		Console.WriteLine("Guess my Number from 0-100");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("Attempts Left: ");

	}
	public void TheGameHard()
	{
		Console.WriteLine("Guess my Number from 0-255");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("Attempts Left: ");

	}
	public void TheGameImpossible()
	{
		Console.WriteLine("Guess my Number from 0-1000");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("Attempts Left: ");

	}
	public void GameEndWin()
    {

    }
	public void GameEndLose()
    {

    }

}
