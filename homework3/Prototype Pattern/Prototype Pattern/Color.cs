using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.PrototypePattern.Practical
{
    // 定义'ColorPrototype'类
 
    public class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // 构造器

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // 利用MemberwiseClone()接口实现浅克隆
 
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}