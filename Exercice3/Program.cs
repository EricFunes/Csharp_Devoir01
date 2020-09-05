using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            string entier1 = "";
            string entier2 = "";

            while (ValideUnEntier("premier", ref entier1) != true) { }

            while (ValideUnEntier("second", ref entier2) != true || ValidationIntervalle(entier1, entier2) != true) { }

            GetSerie(ref entier1, ref entier2);

        }

        private static void GetSerie(ref string entier1, ref string entier2)
        {
            int nb1 = int.Parse(entier1);
            int nb2 = int.Parse(entier2);
            string serie = "";

            while (nb1 <= nb2)
            {
                serie += $"{nb1} ";
                nb1 += 2;
            }
            Console.WriteLine(serie);
        }

        private static Boolean ValidationIntervalle(string entier1, string entier2)
        {

            if (int.Parse(entier1) < int.Parse(entier2))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Le second paramètre est plus petit que le premier.");
                return false;
            }
        }

        private static Boolean ValideUnEntier(string identidiant, ref string entier)
        {
            Console.WriteLine($"{identidiant} entier?");
            entier = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(entier))
            {
                Console.WriteLine($"Le {identidiant} entier n'est pas un entier.");
                return false;
            }
            else if (int.Parse(entier) % 2 != 0)
            {
                Console.WriteLine($"Le {identidiant} n'est pas un entier pair.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}