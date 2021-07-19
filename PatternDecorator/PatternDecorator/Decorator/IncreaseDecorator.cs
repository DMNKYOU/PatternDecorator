using PatternDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator.Decorator
{
    class IncreaseDecorator : Decorator
    {
        public IncreaseDecorator(IComponent component) : base(component) { }
        public override double Operation()
        {
            return 100 + _component.Operation();
        }
    }
}
