using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program1
{
    class Program
    {
        //判断素数
       static bool PrimeNum(int i)
        {
            for(int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("输入一个自然数：");
            bool inIfRight = true;
            int numIn=0;
            //判断输入是否正确
            while (inIfRight)
            {
                try
                {
                    string numStr = Console.ReadLine();
                    numIn = Int32.Parse(numStr);
                    inIfRight = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n请正确输入数字！\n");
                    inIfRight = true;
                }
            }
            Console.Write("其素数因子为：\t");
            for (int i = 1; i <= Math.Sqrt(numIn); i++)
            {
                if (numIn % i == 0)
                {
                    int j = numIn / i;
                    if (PrimeNum(i))
                        Console.Write(i + "\t");
                    if(PrimeNum(j))
                        Console.Write(j + "\t");
                }
            }           
        }
       
    }
}
