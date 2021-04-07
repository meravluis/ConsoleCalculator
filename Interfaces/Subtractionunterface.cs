using System;
using Console_calculator.Operations;


namespace Console_calculator.Interfaces
{
    public class SubtractionInterface
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