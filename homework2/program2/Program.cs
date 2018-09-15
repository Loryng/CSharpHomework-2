using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        //最大值
        static int NumMax(int[] i)
        {
            int numMax = i[0];
            for (int j = 1; j < i.Length; j++)
            {
                if (i[j] > numMax)
                    numMax = i[j];
            }
            return numMax;
        }
        //最小值
        static int NumMin(int[] i)
        {
            int numMin = i[0];
            for (int j = 1; j < i.Length; j++)
            {
                if (i[j] < numMin)
                    numMin = i[j];
            }
            return numMin;
        }
        //平均数
        static float NumAverage(int[] i)
        {
            float sum = 0;
            foreach(int NA in i)
            {
                sum += NA;
            }
            float numAverage = sum / i.Length;

            return numAverage;
        }
        //和
        static int NumSum(int [] i)
        {
            int sum = 0;
            foreach (int NA in i)
            {
                sum += NA;
            }
            return sum;
        }
        static void Main(string[] args)
        {
          
            bool isRight = true;
            int[] a=null;
            while (isRight)
            {
                try
                {
                    Console.Write("数组元素个数：");
                    int count = Convert.ToInt32(Console.ReadLine());
                   a = new int[count];
                    for (int i = 0; i < count; i++)//将输入的数放入数组
                    {
                        Console.Write("a[" + i + "]:");
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    isRight = false;
                }catch(Exception e)
                {
                    Console.WriteLine("\n请正确输入数字！\n");
                    isRight = true;
                }
                
            }
            if (a.Length!=0)
            {
                Console.WriteLine("最大值为：" + NumMax(a));
                Console.WriteLine("最小值为：" + NumMin(a));
                Console.WriteLine("平均值为：" + NumAverage(a));
                Console.WriteLine("和为：" + NumSum(a));
            }
            else
            {
                Console.WriteLine("\n数组为空！\n");
            }
            
        }
    }
}
