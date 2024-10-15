using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDemo
{
    public class Program
    {
        //delegate void Action<T>(T msg);

        static void Main(string[] args)
        {

            //Action<string> strMsg = DisplayStringInConsole;
            //strMsg("I am working for string type");

            //Action<char> charMsg = DisplayCharInConsole;
            //charMsg('A');

            Action voidAction = PrintMethod;
            voidAction();

            Action<int, double> action = ParametrisizedMethod;
            action(2,2.5);

            Console.ReadKey();
        }

        static void PrintMethod()
        {
            Console.WriteLine("I am PrintMethod!");
        }

        static void ParametrisizedMethod(int x, double y)
        {
            Console.WriteLine(x + y);
        }

        //static void DisplayStringInConsole(string txt)
        //{
        //    Console.WriteLine(txt);
        //}

        //static void DisplayCharInConsole(char txt)
        //{
        //    Console.WriteLine(txt);
        //}
    }
}
