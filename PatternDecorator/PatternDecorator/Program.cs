using System;
using PatternDecorator.Decorator;
using PatternDecorator.Component;


namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component.Component();
            Console.WriteLine(component.Operation());
            Decorator.Decorator decoratorA = new IncreaseDecorator(component);
            Console.WriteLine(decoratorA.Operation());
            Decorator.Decorator decoratorB = new DecreaceDecorator(component);
            Console.WriteLine(decoratorB.Operation());
        }
    }
}
