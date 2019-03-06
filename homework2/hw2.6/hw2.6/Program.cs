using System;

namespace hw2._6
{
    class Program
    {
        static void judge_prime(int number)
        {
            int count=0;
            for(int i=1;i<=number;i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine(number);
        }

        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("请输入一个数");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("所有素数因子为:");
            for(int i=1;i<=a;i++)
            {
                if (a % i == 0)
                    judge_prime(i);
            }
        }
    }
}
