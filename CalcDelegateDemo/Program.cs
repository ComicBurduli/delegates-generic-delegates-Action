using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDelegateDemo
{
    public delegate int CalcOperationDelegate(int x, int y);
    public static class Calculator
    {
        public static int PerformOperation(int x, int y, CalcOperationDelegate ops)
        {
            return ops(x, y);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int resultAdd = Calculator.PerformOperation(2, 3, Add);
            int resultAsubstract = Calculator.PerformOperation(2, 3, Substract);
            int resultMultiply = Calculator.PerformOperation(2, 3, Multiply);

            Console.WriteLine(resultAdd);
            Console.WriteLine(resultAsubstract);
            Console.WriteLine(resultMultiply);

            Console.ReadKey();

        }

        static int Add(int x, int y)
        {   
            return x + y; 
        }

        static int Substract(int x, int y)
        {
            return x - y;    
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
