using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Devoir01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (TextValidation(ref input) != true) { }

            Console.WriteLine($"{GetMessage(input)}");
        }

        private static string GetMessage(string input)
        {
            string message = "";
            int repeat = Repetition();
            int index = 0;

            while (index < repeat)
            {
                message += $"{input}\n";
                index++;
            }
            return message;
        }

        private static Boolean TextValidation(ref string input)
        {
            Console.WriteLine("Texte?");
            input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input.ToString()))
            {
                Console.WriteLine("Vous n'avez rien écris.");
                return false;
            }

            return true;
        }

        private static Int32 Repetition()
        {
            Console.WriteLine("Nombre de répétition?");
            Int32 repeat = Int32.Parse(Console.ReadLine());

            if (repeat.GetType() != typeof(Int32))
            {
                Console.WriteLine("Erreur.");
            }
            return repeat;
        }
    }
}
