using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    delegate void Message();
    delegate void Operations(int x, int y);

    public class Program
    {
        static void Main(string[] args)
        {
            //Message message;
            //message = Display;

            Message message = Display;
            message(); // v1

            message.Invoke(); // v2

            Operations ops = Sum;
            ops += Multiply;

            ops(2, 3);

            Console.ReadKey();
        }

        static void Display()
        {
            Console.WriteLine("I am Display Method");
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }
}
