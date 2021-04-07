using System.Collections.Generic;
using Console_calculator.Interfaces;
using ConsoleCalculator.Contracts;

namespace ConsoleCalculator.Strategies
{
    public class VisualInterfaceContext
    {
        private readonly Dictionary<string, IVisualInterface> _strategies;
        private IVisualInterface _strategy;
        
        public VisualInterfaceContext()
        {
            _strategies = new Dictionary<string, IVisualInterface>();
            
            _strategies.Add("1", new AdditionInterface());
            _strategies.Add("2", new SubtractionInterface());
            _strategies.Add("3", new MultiplicationInterface());
            _strategies.Add("4", new DivitionInterface());
        }

        public void SetStrategy(string selectedStrategy)
        {
            _strategy = _strategies.GetValueOrDefault(selectedStrategy);
        }

        public void Display()
        {
            _strategy.Display();   
        }
    }
}