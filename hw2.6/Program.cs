using System;

namespace hw2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i;
            Console.Write("请输入一个数字:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("该数的因子为:");
            for (i = 1;  i <= a;  i++ )
            {   
                if (a % i == 0)
                {
                    Console.Write("{0} ", i);
                }

            }
            Console.WriteLine("");
            

        }
    }
}
