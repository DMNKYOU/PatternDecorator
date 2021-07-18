using PatternDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator.Decorator
{
    abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        { 
            _component = component;
        }
        public abstract double Operation();
    }
}
