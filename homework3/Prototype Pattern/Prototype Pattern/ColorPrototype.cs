using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.PrototypePattern.Practical
{
    // Prototype的abstract定义

    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}