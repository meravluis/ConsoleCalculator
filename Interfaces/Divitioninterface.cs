using System;
using Console_calculator.Operations;


namespace Console_calculator.Interfaces
{
    public class DivitionInterface
    {
        public void Display ()
        {
            Console.WriteLine("== Divition ==");
            Console.WriteLine("Insert First Number: ");
            Console.WriteLine("Insert second number: ");

            Divition divition= new Divition();

            float result = divition.Execute(14,3);
            
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}