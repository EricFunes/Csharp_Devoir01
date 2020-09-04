using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entier = "";
            ArrayList list = new ArrayList();

            Console.WriteLine("premier entier?");
            while (ValideUnEntier(ref entier, ref list) != true)
            {
            }

            Console.WriteLine("second entier?");
            while (ValideUnEntier(ref entier, ref list) != true)
            {
            }

            GetSerie(ref list);
        }

        private static Boolean ValideUnEntier(ref string entier, ref ArrayList list)
        {
            entier = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(entier.ToString()))
            {
                Console.WriteLine($"Le X entier n'est pas un entier.");
                return false;
            }
            else if (int.Parse(entier) % 2 != 0)
            {
                Console.WriteLine($"Le X entier n'est pas un entier pair.");
                return false;
            }
            else
            {
                list.Add(entier);
                return true;
            }
        }

        private static void GetSerie(ref ArrayList list)
        {
            string result = "";
            foreach (var item in list)
            {
                result += $"{item} ";
            }
            Console.WriteLine(result);
        }
    }
}