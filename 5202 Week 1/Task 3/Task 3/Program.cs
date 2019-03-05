using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number from 1-10");
            int wholenumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input a different number from 1-10");
            int wholenumber2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input a decimal number from 1.1-1.10");
            decimal decimalnumber1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please input a different decimal number from 1.1-1.10");
            decimal decimalnumber2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What city are you from?");
            string city = Console.ReadLine();

            Console.WriteLine("What is your occupation?");
            string occupation = Console.ReadLine();

            Console.WriteLine(wholenumber1);
            Console.WriteLine(wholenumber2);
            Console.WriteLine(decimalnumber1);
            Console.WriteLine(decimalnumber2);
            Console.WriteLine(city);
            Console.WriteLine(occupation);

            Console.ReadLine();









        }
    }
}
