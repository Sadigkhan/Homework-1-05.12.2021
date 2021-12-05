using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1__05._12._2021
{
    internal class Tersyaz
    {
        public string TersCumle(string cml)
        {
            string result = String.Empty;
            string[] arr = cml.Split(' ');
            Console.WriteLine($"Daxil edilmis cumlenin tersi {result}");
            foreach (string soz in arr)
            {
                for (int i = soz.Length - 1; i >= 0; i--)
                {
                    result += soz[i];
                }
                if (result.Length < cml.Length)
                    result += " ";
            }
            return result;
        }
    }
}
