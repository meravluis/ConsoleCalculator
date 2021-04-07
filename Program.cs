using System;
using Console_calculator.Interfaces;


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
            switch (OpcionSeleccionada)
            {
                case "1":
                   
                    AdditionInterface additionInterface = new AdditionInterface();
                    additionInterface.Display();
                    break;

                case "2":

                    SubtractionInterface subtractionInterface =new SubtractionInterface();
                    subtractionInterface.Display();
                    break;

                case "3":

                    MultiplicationInterface multiplicationInterface = new MultiplicationInterface();
                    multiplicationInterface.Display();
                    break;


                case "4":
                
                    DivitionInterface divitionInterface = new DivitionInterface();
                    divitionInterface.Display();
                    break;

                default:
                break;
            }  
        }
    }
}
