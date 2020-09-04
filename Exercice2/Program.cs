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
            string entier1 = "";
            string entier2 = "";
            ArrayList list = new ArrayList();

            while (ValidationNum1(ref entier1) != true) { }
            //AddToList(entier1, list);

            while (ValidationNum2(entier1, ref entier2) != true) { }
            //AddToList(entier2, list);

            //GetList(ref list);
            GenererSuite(ref entier1, ref entier2);
            
        }
        private static void AddToList(string input, ArrayList list)
        {
            list.Add(input);
        }

        private static void GetList(ref ArrayList list)
        {
            string result = "";
            foreach (var item in list)
            {
                //result += $"{item}, ";
                result += $"{item} ";
            }
            //Console.WriteLine(result.Substring(0, result.Length -2));
            Console.WriteLine(result);
        }

        private static void GenererSuite(ref string entier1, ref string entier2)
        {
            
            int nb1 = int.Parse(entier1);
            string serie = "";
            
            while (nb1 <= int.Parse(entier2))
            {
                serie += $"{nb1} ";
                nb1 += 2;
            }
            Console.WriteLine(serie);
        }

        private static Boolean ValidationIntervalle(string entier1, ref string entier2)
        {
            entier2 = Console.ReadLine();

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

        private static Boolean ValidationNum1(ref string entier1)
        {
            Console.WriteLine("premier entier?");
            entier1 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(entier1.ToString()))
            {
                Console.WriteLine("Le premier entier n'est pas un entier.");
                return false;
            }
            else if (int.Parse(entier1) % 2 != 0)
            {
                Console.WriteLine("Le premier entier n'est pas un entier pair.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static Boolean ValidationNum2(string entier1, ref string entier2)
        {
            Console.WriteLine("second entier?");
            
            while (ValidationIntervalle(entier1, ref entier2) != true) { }

            if (String.IsNullOrWhiteSpace(entier2))
            {
                Console.WriteLine("Le second entier n'est pas un entier.");
                return false;
            }
            else if (int.Parse(entier2) % 2 != 0)
            {
                Console.WriteLine("Le second entier n'est pas un entier pair.");
                return false;
            }
            return true;
        }
    }
}   