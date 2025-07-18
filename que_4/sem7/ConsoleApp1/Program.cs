//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
using System;
using System.Numerics;  // For INumber<T>

namespace GenericCalculator
{
    public class Calculator<T> where T : INumber<T>
    {
        public T Add(T a, T b) => a + b;
        public T Subtract(T a, T b) => a - b;
        public T Multiply(T a, T b) => a * b;
        public T Divide(T a, T b)
        {
            if (b == T.Zero)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var intCalc = new Calculator<int>();
            Console.WriteLine("Integers:");
            Console.WriteLine($"5 + 3 = {intCalc.Add(5, 3)}");
            Console.WriteLine($"10 - 7 = {intCalc.Subtract(10, 7)}");
            Console.WriteLine($"4 * 6 = {intCalc.Multiply(4, 6)}");
            Console.WriteLine($"20 / 5 = {intCalc.Divide(20, 5)}");

            var doubleCalc = new Calculator<double>();
            Console.WriteLine("\nDoubles:");
            Console.WriteLine($"5.5 + 3.3 = {doubleCalc.Add(5.5, 3.3)}");
            Console.WriteLine($"10.0 - 7.7 = {doubleCalc.Subtract(10.0, 7.7)}");
            Console.WriteLine($"4.2 * 6.5 = {doubleCalc.Multiply(4.2, 6.5)}");
            Console.WriteLine($"20.0 / 4.0 = {doubleCalc.Divide(20.0, 4.0)}");
        }
    }
}

