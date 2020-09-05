using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "";
            string year = "";

            askDate(ref month, ref year);

        }
        private static void askDate(string month, string year)
        {
            Console.WriteLine("Mois en chiffre?");
            validateMonth(ref month);

        }

        private static Boolean validateMonth(ref string month)
        {
            month = Console.ReadLine();
            if (int.Parse(month) > 0 || int.Parse(month) <= 12)
            {
                return true;
            }
            return false;
        }

        private static Boolean validateYear(ref string year)
        {
            year = Console.ReadLine();
            if (int.Parse(year) > 0 || int.Parse(year) <= 12)
            {
                return true;
            }
            return false;
        }
    }
}
