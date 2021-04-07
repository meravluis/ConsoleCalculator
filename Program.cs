using System;
using ConsoleCalculator.Strategies;

namespace Console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("Choose your Option: ");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Substraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Divition");

            string OpcionSeleccionada = Console.ReadLine();

            VisualInterfaceContext visualInterface = new VisualInterfaceContext();

            visualInterface.SetStrategy(OpcionSeleccionada);

            visualInterface.Display();
        }
    }
}
