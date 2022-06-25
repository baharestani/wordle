namespace Wordle.Console;

public class WordPrinter
{
    public void PrintLine(string word, InspectionResults[] results)
    {
        ConsoleColor defaultBackground = System.Console.BackgroundColor;
        ConsoleColor defaultForeground = System.Console.ForegroundColor;

        System.Console.ForegroundColor = ConsoleColor.White;
 
        for (int i = 0; i < word.Length; i++)
        {
            switch (results[i])
            {
                case InspectionResults.Exact:
                    System.Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case InspectionResults.Present:
                    System.Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    System.Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }

            System.Console.Write($" {word[i].ToString().ToUpper()} ");
        }
        System.Console.BackgroundColor = defaultBackground;
        System.Console.ForegroundColor = defaultForeground;
        System.Console.WriteLine();
    }
}
