using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_6_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите предложение содержащее слово в фигурных скобках: ");
            string s = Console.ReadLine();
            string s2 = System.Text.RegularExpressions.Regex.Replace (s, @"{[\d\D]+}", "");
            Console.WriteLine(s);
                                
            Console.WriteLine(s2);
            Console.ReadKey();

            
        }
    }
}
