
using System;

namespace hw2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 5, 8, 9, 12, 18, 19, 21, 24, 26 };
            int max = a[0];
            int min = a[0];
            int i= 0;
            float sum = 0;

            for(i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
                if(a[i]<min)
                {
                    min = a[i];
                }

                sum += a[i];

            }
            double avg = sum / 10;


            Console.WriteLine("最大值为:{0}",max );
            Console.WriteLine("最小值为:{0}",min );
            Console.WriteLine("平均值为:{0}",avg);
            Console.WriteLine("数组元素和为:{0}", sum);


        }
    }
}
