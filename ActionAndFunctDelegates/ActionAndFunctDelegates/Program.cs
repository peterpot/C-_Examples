using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFunctDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, ConsoleColor, int> action =
                new Action<string, ConsoleColor, int>(DisplayMessage);

            action("Sabina", ConsoleColor.Blue, 4);


            Func<int, int, string> funct = new Func<int, int, string>(Sum);
            string result = funct(22, 9);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        // -----------------------
        // ACTION - ONLY FOR VOID:
        // -----------------------
        static void DisplayMessage(string message, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;

            Console.BackgroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(message);
            }


            Console.ForegroundColor = previous;

        }

        // -----------------------
        // FUNCT - FOR RETURNING:       
        // -----------------------

        static string Sum(int x, int y)
        {
            return (x + y).ToString();
        }

    }
}
