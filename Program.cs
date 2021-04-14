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
            Console.WriteLine("5) Power");

            string OpcionSeleccionada = Console.ReadLine();

            VisualInterfacesContext context = new VisualInterfacesContext();

            switch (OpcionSeleccionada)
            {
                case "1":
                    context.SetInterface(VisualInterfaceEnum.Addition);
                    break;
                case "2":
                    context.SetInterface(VisualInterfaceEnum.Substraction);
                    break;
                case "3":
                    context.SetInterface(VisualInterfaceEnum.Multiplication);
                    break;
                case "4":
                    context.SetInterface(VisualInterfaceEnum.Divition);
                    break;
                case "5":
                    context.SetInterface(VisualInterfaceEnum.Power);
                    break;
            }

            context.DisplayInterface();
        }
    }
}
