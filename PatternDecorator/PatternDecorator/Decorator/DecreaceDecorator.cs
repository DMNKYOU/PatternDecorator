using PatternDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator.Decorator
{
    class DecreaceDecorator : Decorator
    {
        public DecreaceDecorator(IComponent component) : base(component) { }
        public override double Operation()
        {
            return _component.Operation() - 100;
        }
    }
}
