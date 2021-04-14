using System.Collections.Generic;
using Console_calculator.Interfaces;
using ConsoleCalculator.Contracts;

namespace ConsoleCalculator.Strategies
{
    public class VisualInterfacesContext
    {
        private Dictionary<VisualInterfaceEnum, IVisualInterface> interfaces;
        private IVisualInterface interfazSeleccionada;

        public VisualInterfacesContext()
        {
            interfaces = new Dictionary<VisualInterfaceEnum, IVisualInterface>();

            interfaces.Add(VisualInterfaceEnum.Addition, new AdditionInterface());
            interfaces.Add(VisualInterfaceEnum.Substraction, new SubtractionInterface());
            interfaces.Add(VisualInterfaceEnum.Multiplication, new Powerinterface());
            interfaces.Add(VisualInterfaceEnum.Divition, new DivitionInterface());
            interfaces.Add(VisualInterfaceEnum.Power, new Powerinterface());
        }

        public void SetInterface(VisualInterfaceEnum visualInterface)
        {
            interfazSeleccionada = interfaces.GetValueOrDefault(visualInterface);
        }

        public void DisplayInterface()
        {
            interfazSeleccionada.Display();
        }
    }

    public enum VisualInterfaceEnum
    {
        Addition,
        Substraction,
        Multiplication,
        Divition,
        Power
    }
}