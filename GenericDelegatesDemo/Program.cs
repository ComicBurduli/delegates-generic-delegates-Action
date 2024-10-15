using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegatesDemo
{
    public class Program
    {
        delegate void Message(string msg);
        //delegate void charMessage(char msg);

        delegate void Message<T>(T msg);

        static void Main(string[] args)
        {
            // 1. რომლის დასაბრუნებელი მნიშვნელობა (ტიპი) არის void.
            // 2. რომელიც აბრუნებს int, double, string, enum და აშ.
            // 3. რომელიც აბრუნებს ლოგიკურ მნიშვნელობას => bool
            //Message msg = DisplayDataInConsole;
            //msg("Hello, guys!");

            Message<string> strMsg = DisplayStringInConsole;
            strMsg("I am working for string type");

            Message<char> charMsg = DisplayCharInConsole;
            charMsg('A');

            Console.ReadKey();

        }

        static void DisplayStringInConsole(string txt)
        {
            Console.WriteLine(txt);
        }

        static void DisplayCharInConsole(char txt)
        {
            Console.WriteLine(txt);
        }
    }
}
