using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your physical address?");
            string paddress = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your email address?");
            string eaddress = Console.ReadLine();

            Console.WriteLine("What is your 4 digit pin?");
            int pin = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello" + " " + name);
            Console.WriteLine("Your physical address is: " + " " + paddress);
            Console.WriteLine("Your age is:" + " " + age);
            Console.WriteLine("Your email address is:" + " " + eaddress);
            Console.WriteLine("Your pin number is:" + " " + pin);

            Console.ReadLine();

        }
    }
}
