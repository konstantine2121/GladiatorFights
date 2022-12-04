using System;

namespace GladiatorFights
{
    class ConsoleOutputMethods
    {
        public static void WriteLine(string message, ConsoleColor foregroundColor = ConsoleColor.White)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        public static void Info(string message, ConsoleColor foregroundColor = ConsoleColor.Green)
        {
            WriteLine(message, foregroundColor);
        }

        public static void Warning(string message, ConsoleColor foregroundColor = ConsoleColor.Yellow)
        {
            WriteLine(message, foregroundColor);
        }
    }
}
