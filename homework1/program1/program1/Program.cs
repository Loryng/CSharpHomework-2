using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//第1章第4题
namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {   //所交的作业
            //Console.Write("第一个数:");
            //string st1 = Console.ReadLine();
            //double num1 = Int32.Parse(st1);
            //Console.Write("第二个数:");
            //string st2 = Console.ReadLine();
            //double num2 = Int32.Parse(st2);
            //double pro = num1 * num2;
            //Console.WriteLine("两者的积为:" + pro);

            //如果在实际项目开发，需要考虑各种异常地抛出
            //Int32.parse()和Convert.ToInt32()都会抛出异常

            //改进
            bool T= true;
            while (T){
                try
                {
                    Console.Write("第一个数:");
                    string st11 = Console.ReadLine();
                    double num11 = Int32.Parse(st11);
                    Console.Write("第二个数:");
                    string st21 = Console.ReadLine();
                    double num21 = Int32.Parse(st21);
                    double pro1 = num11 * num21;
                    Console.WriteLine("两者的积为:" + pro1);
                    T = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("请正确输入数字！");
                    T = true;
                }
            }
        }
    }
}
