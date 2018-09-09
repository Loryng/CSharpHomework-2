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
        {
            Console.Write("第一个数:");
            string st1 = Console.ReadLine();
            double num1 = Int32.Parse(st1);

            Console.Write("第二个数:");
            string st2 = Console.ReadLine();
            double num2 = Int32.Parse(st2);

            double pro = num1 * num2;
            Console.WriteLine("两者的积为:" + pro);
        }
    }
}
