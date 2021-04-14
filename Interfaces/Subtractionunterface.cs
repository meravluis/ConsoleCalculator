using System;
using Console_calculator.Operations;
using ConsoleCalculator.Contracts;

namespace Console_calculator.Interfaces
{
    public class SubtractionInterface : IVisualInterface
    {
        public void Display ()
        {
            Console.WriteLine("== Subtraction ==");
            Console.WriteLine("Insert First Number: ");
            Console.WriteLine("Insert second number: ");

            Subtraction subtraction = new Subtraction();

            int result = subtraction.Execute(5,7);
            
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}