using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.PrototypePattern.Practical
{
 
    // Manager类
 
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

 
        // 索引器
 
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}