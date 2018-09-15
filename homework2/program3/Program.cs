using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool T = true;
            while (T)
            {
                Console.Write("请输入一个数，将在这个范围内取素数：");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("\n请输入自然数！\n");
                        continue;
                    }
                    T = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n请输入自然数！\n");
                    T = true;
                }
            }
            //创建数组
           int[] naturalArray = new int[num];
           for (int natural = 1,k=0; natural <= num; natural++,k++)
            {
                naturalArray[k] = natural;
            }
            ArrayList list = new ArrayList(naturalArray); 
            //去掉倍数
            for(int i = 2; i <Math.Sqrt(num);i++)
            {
               // int remainNum = 0;
                Console.Write("\n去掉" + i + "的倍数：");            
                for(int j = 1; j <= num; j++)
                {
                    if((j%i==0 && j/i!=1 ) || j==1)
                    {
                        list.Remove(j);
                    }
                }
                foreach(int b in list)
                {
                    Console.Write(b + "  ");
                }             
                Console.Write("\n");
            }
            //添加10以内的素数
            //int[] Arr = { 2, 3, 5, 7 };
            //list.InsertRange(0, Arr);
            Console.Write("\n"+num + "内的素数是：");
            foreach (int b in list)//输出素数
            {
                Console.Write(b + "  ");
            }
            Console.Write("\n");
            Console.WriteLine("\n素数个数为：" + list.Count+"\n");
        }
    }
}
