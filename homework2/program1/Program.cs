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
            if (i == 1)
            {
                return false;
            }
            for(int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    return false;
            }
            return true;
        }
        //计算因子
        static int Divisor(int numIn)
        {
            Console.Write("The prime factors：\t");
            for (int i = 1; i <= Math.Sqrt(numIn); i++)
            {
                if (numIn % i == 0)
                {
                    int j = numIn / i;
                    if (PrimeNum(i))
                    {
                        Console.Write(i + "\t");
                        Countprime++;//有一个素数就加一
                    }

                    if (PrimeNum(j))
                    {
                        if (i != j)
                            Console.Write(j + "\t");
                        Countprime++;
                    }

                }
            }

            if (Countprime == 0)
            {
                Console.WriteLine("There are no prime factors");
            }
            Console.WriteLine("The number of prime factors:" + Countprime);
            return 0;
        }
        static int Countprime = 0;//统计素数因子的个数
        static void Main(string[] args)
        {       
            bool inIfRight = true;
            int numIn=0;
            //判断输入是否正确
            while (inIfRight)
            {
                Console.Write("Enter a natural number：");
                try
                {
                    string numStr = Console.ReadLine();
                    numIn = Int32.Parse(numStr);
                    if (numIn <= 0)
                    {
                        Console.WriteLine("\n Please enter the correct number ！\n");
                        continue;
                    }
                    inIfRight = false;
                }
                catch (Exception e)
                {
                    inIfRight = true;
                }
            }
            Divisor(numIn);       
        }   
    }
}
