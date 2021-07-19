using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator.Component
{
    public class Component: IComponent
    {
        public double Operation()
        {
            Random rnd = new Random();
            return rnd.NextDouble() % 100;
        }
    }
}
