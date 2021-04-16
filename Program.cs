using System;
using ConsoleCalculator.Strategies;

namespace Console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            VisualInterfacesContext context = new VisualInterfacesContext();

            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("Choose your Option: ");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Substraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Divition");
            Console.WriteLine("5) Power");

            string OpcionSeleccionada = Console.ReadLine();

            Enum.TryParse<VisualInterfaceEnum>(OpcionSeleccionada, out VisualInterfaceEnum opcionEnum);

            context.SetInterface(opcionEnum);
            context.DisplayInterface();
        }
    }
}
