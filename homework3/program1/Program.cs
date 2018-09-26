using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
   
    //抽象父类
    abstract class Chart
    {
        public float ChartArea; 
        public Chart()
        {       
        }        
        public abstract void Area();
        public void Display()
        {
            Console.WriteLine("面积为" + ChartArea);
        }
    }
    
    //具体实现类
    class Circle : Chart
    {
        private float Radius;
        public Circle(float b)
        {
            this.Radius = b;
        }
        public override void Area()
        {
            ChartArea =(float)(Radius * Radius * Math.PI);
        }
    }

    class Trilateral : Chart
    {
        private float hight;
        private float width;
        public Trilateral(float b, float c)
        {
            hight = b;
            width = c;
        }
        public override void Area()
        {
            ChartArea = hight * width;
        }
        
    }

    class Square : Chart
    {
        private float side;
        public Square(float b)
        {
            side = b;
        }
        public override void Area()
        {
            ChartArea = side * side;
        }
       
    }

    class Rectangle : Chart
    {
        private float hight;
        private float width;
        public Rectangle( float b, float c)
        {
            hight = b;
            width = c;
        }
        public override void Area()
        {
            ChartArea = hight * width;
        }
       
    }

    class Factory
    {
        public static Chart GetChart(string cha,float s,float w=1)
        {
            Chart chart = null;
            
            if (cha.Equals("Trilateral"))
            {
                chart = new Trilateral(s, w);
            }
            else if (cha.Equals("Rectangle"))
            {
                chart = new Rectangle(s, w);
            }
            else if(cha.Equals("Circle"))
            {
                chart = new Circle(s);
            }
            else if (cha.Equals("Square"))
            {
                chart = new Square(s);
            }
            return chart;
        }
        //public static Chart GetChart(string cha, float s)
        //{
        //    Chart chart = null;
        //    if (cha.Equals("Circle"))
        //    {
        //        chart = new Circle(s);
        //    }
        //    else if (cha.Equals("Square"))
        //    {
        //        chart = new Square(s);
        //    }
        //    return chart;
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            bool T = true;
            while (T)
            {
                try
                {
                    Console.WriteLine("从下列选择一个图形：\n  Circle  \t Square \t  Trilateral \t Rectangle \n");
                    Console.Write("您的图形是：");
                    string inp = Console.ReadLine();
                    float R = 0, H = 1;
                    if (inp.Equals("Circle"))
                    {
                        Console.WriteLine("输入圆的半径:");
                        R = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (inp.Equals("Square"))
                    {
                        Console.WriteLine("输入边长:");
                        R = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (inp.Equals("Trilateral"))
                    {
                        Console.WriteLine("输入底和高:");
                        R = Convert.ToInt32(Console.ReadLine());
                        H = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (inp.Equals("Rectangle"))
                    {
                        Console.WriteLine("输入长和宽:");
                        R = Convert.ToInt32(Console.ReadLine());
                        H = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        throw new AccessViolationException("请输入正确的图形");
                    }
                    Chart chart;
                    chart = Factory.GetChart(inp, R, H);
                    chart.Area();
                    chart.Display();
                    T = false;
                }
                catch
                {
                    Console.WriteLine("\n 请正确输入上述的图形 \n");
                }
            }
           
            
        }
    }
}
