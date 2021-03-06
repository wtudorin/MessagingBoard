﻿using MessageBoard.ConsoleUI.Command;
using System;
using System.Collections.Generic;

namespace MessageBoard.ConsoleUI
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			CommandParser commandParser = new CommandParser();
			while (true)
			{
				Console.Write("Command > ");
				var commandLine = Console.ReadLine();
				commandParser.ClearCommands();
				commandParser.AddCommand(new PostMessageCommand());
				var command = commandParser.Parse(commandLine);

				List<string> resultList = null;

				if (command != null)
				{
					resultList = command.Execute();
				}
			}
		}
	}
}