using System.Collections.Generic;
using Console_calculator.Interfaces;
using ConsoleCalculator.Contracts;

namespace ConsoleCalculator.Strategies
{
    public class VisualInterfacesContext
    {
        private Dictionary<string, IVisualInterface> interfaces;
        private IVisualInterface interfazSeleccionada;

        public VisualInterfacesContext()
        {
            interfaces = new Dictionary<string, IVisualInterface>();

            interfaces.Add("1", new AdditionInterface());
            interfaces.Add("2", new SubtractionInterface());
            interfaces.Add("3", new Powerinterface());
            interfaces.Add("4", new DivitionInterface());
            interfaces.Add("5", new Powerinterface());
        }

        public void SetInterface(string visualInterface)
        {
            interfazSeleccionada = interfaces.GetValueOrDefault(visualInterface);
        }

        public void DisplayInterface()
        {
            interfazSeleccionada.Display();
        }
    }
}