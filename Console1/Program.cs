using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Принять с консоли 3 числа и перемножить их, результат вывести на консоль
            Console.WriteLine("Введите переменные a, b, c");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a*b*c);
            Console.ReadKey();
         }
    }
}
