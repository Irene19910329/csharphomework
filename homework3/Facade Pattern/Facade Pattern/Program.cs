using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.FacadePattern.Structural;

namespace DesignPatterns.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}