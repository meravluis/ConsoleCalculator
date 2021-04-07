using System;
using Console_calculator.Operations;
using ConsoleCalculator.Contracts;

namespace Console_calculator.Interfaces
{
    public class MultiplicationInterface : IVisualInterface
    {
        public void Display ()
        {
            Console.WriteLine("== Multiplication ==");
            Console.WriteLine("Insert First Number: ");
            Console.WriteLine("Insert second number: ");

            Multiplication multiplication = new Multiplication();

            int result = multiplication.Execute(5,7);
            
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}