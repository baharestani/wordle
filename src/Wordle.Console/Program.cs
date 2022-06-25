// See https://aka.ms/new-console-template for more information
using Wordle;
using System;

var game = new Game(new RandomWordProvider());
var printer = new Wordle.Console.WordPrinter();
string? guess;

System.Console.WriteLine("READY!");

do
{
    guess = Console.ReadLine();
    if (String.IsNullOrEmpty(guess))
    {
        return;
    }
    System.Console.SetCursorPosition(0, System.Console.CursorTop - 1);
    try
    {
        var result = game.Check(guess);
        printer.PrintLine(guess, result);
    }
    catch (System.Exception)
    {
        System.Console.Write("Again: ");
    }
} while (guess != game.Word);


