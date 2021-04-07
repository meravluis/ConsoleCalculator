using System;
using Console_calculator.Operations;


namespace Console_calculator.Interfaces
{
    public class AdditionInterface
    {
        public void Display ()
        {
            Console.WriteLine("== Addition ==");
            Console.WriteLine("Insert First Number: ");
            Console.WriteLine("Insert second number: ");

            Addition addition = new Addition();

            int result = addition.Execute(5,7);
            
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}