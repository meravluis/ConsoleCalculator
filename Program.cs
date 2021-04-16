using System;
using ConsoleCalculator.Strategies;

namespace Console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string OpcionSeleccionada = "";
            do
            {
                Console.WriteLine("Welcome to the Calculator");
                Console.WriteLine("Choose your Option: ");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Substraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Divition");
                Console.WriteLine("5) Power");
                Console.WriteLine("0) Exit");

                OpcionSeleccionada = Console.ReadLine();

                if(OpcionSeleccionada != "0")
                {
                    VisualInterfacesContext context = new VisualInterfacesContext();

                    context.SetInterface(OpcionSeleccionada);
                    context.DisplayInterface();
                }
            }
            while(OpcionSeleccionada != "0");
        }
    }
}
