using System;
using Console_calculator.Operations;
using ConsoleCalculator.Contracts;

namespace Console_calculator.Interfaces
{
    public class Powerinterface : IVisualInterface
    {
        public void Display ()
        {
            Console.WriteLine("== Power ==");
            Console.WriteLine("Insert Number: ");

            Power Power = new Power();

            int result = Power.Execute(5);
            
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}