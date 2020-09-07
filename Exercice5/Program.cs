using System;
using System.Globalization;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "";
            string year = "";
            int[,] calendar = new int[6, 7];

            askDate(ref month, ref year);

            Console.Write("\n");

            Console.WriteLine($"Affichage du calendrier du mois {int.Parse(month)} de l'année {year}");
            Console.WriteLine("Mo Tu We Th Fr Sa Su");

            fillCalendar(ref month, ref year, ref calendar);
            drawCalendar(ref calendar);

        }

        // BUG: When month = 3 and year = 2020, calendar starts at 2...
        private static void askDate(ref string month, ref string year)
        {
            while (validateMonth(ref month) != true) { };
            while (validateYear(ref year) != true) { };

        }

        private static Boolean validateMonth(ref string month)
        {
            Console.WriteLine("Mois en chiffre?");
            month = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(month))
            {
                validateMonth(ref month);
            }

            if (int.Parse(month) > 0 && int.Parse(month) <= 12)
            {
                return true;
            }
            return false;
        }

        private static Boolean validateYear(ref string year)
        {
            Console.WriteLine("Années en chiffre?");
            year = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(year))
            {
                validateMonth(ref year);
            }

            if (int.Parse(year) > 0)
            {
                return true;
            }
            return false;
        }

        private static void fillCalendar(ref string month, ref string year, ref int[,] calendar)
        {
            DateTime date;
            date = new DateTime(int.Parse(year), int.Parse(month), 1);
            int days = DateTime.DaysInMonth(int.Parse(year), int.Parse(month));
            int currentDay = 1;
            var dayOfWeek = (int)date.DayOfWeek;
            
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && int.Parse(month) > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        private static void drawCalendar(ref int[,] calendar)
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }

    }
}