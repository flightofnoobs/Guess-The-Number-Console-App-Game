using System;

public class Game
{

	public void TheGameEasy()
	{
		var m = new MainMenu();
		m.numberOfAttempts = 3;
		m.myNumber = new Random().Next(0, 10);
		while (m.numberOfAttempts >= 0)
        {
			Console.Clear();
			Console.WriteLine("Guess my Number from 0-10");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Attempts Left: " + m.numberOfAttempts);
			int theGuess = int.Parse(Console.ReadLine());

			if (theGuess == m.myNumber)
            {
				GameEndWin();
				break;
            }
			m.numberOfAttempts--;
		}
		if (m.numberOfAttempts <= 0)
        {
			GameEndLose();
		}
	}
	public void TheGameMedium()
	{
		var m = new MainMenu();
		m.numberOfAttempts = 3;
		m.myNumber = new Random().Next(0, 100);
		while (m.numberOfAttempts >= 0)
        {
			Console.Clear();
			Console.WriteLine("Guess my Number from 0-100");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Attempts Left: " + m.numberOfAttempts);
			int theGuess = int.Parse(Console.ReadLine());
			if (theGuess == m.myNumber)
			{
				GameEndWin();
				break;
			}
			m.numberOfAttempts--;
		}
		if (m.numberOfAttempts <= 0)
		{
			GameEndLose();
		}
	}
	public void TheGameHard()
	{
		var m = new MainMenu();
		m.numberOfAttempts = 5;
		m.myNumber = new Random().Next(0, 255);
		while (m.numberOfAttempts >= 0)
        {
			Console.Clear();
			Console.WriteLine("Guess my Number from 0-255");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Attempts Left: " + m.numberOfAttempts);
			int theGuess = int.Parse(Console.ReadLine());
			if (theGuess == m.myNumber)
			{
				GameEndWin();
				break;
			}
			m.numberOfAttempts--;
		}
		if (m.numberOfAttempts <= 0)
		{
			GameEndLose();
		}
	}
	public void TheGameImpossible()
	{
		var m = new MainMenu();
		m.numberOfAttempts = 5;
		m.myNumber = new Random().Next(0, 1000);
		while (m.numberOfAttempts >= 0)
        {
			Console.Clear();
			Console.WriteLine("Guess my Number from 0-1000");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Attempts Left: " + m.numberOfAttempts);
			int theGuess = int.Parse(Console.ReadLine());
			if (theGuess == m.myNumber)
			{
				GameEndWin();
				break;
			}
			m.numberOfAttempts--;
		}
		if (m.numberOfAttempts <= 0)
		{
			GameEndLose();
		}
	}
	public void GameEndWin()
    {
		Console.Clear();
		var m = new MainMenu();
		Console.Write("Wow You Won\nNow Press any key to Continue...");
		Console.ReadKey();
		m.TheMainMenu();
    }
	public void GameEndLose()
    {
		var m = new MainMenu();
		Console.Clear();
		Console.Write("What a loser \nsucks to suck lololoololololol\nNow Press any key to go back lmaoooo");
		Console.ReadKey();
		m.TheMainMenu();
	}

}
