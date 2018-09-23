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
        public static Chart GetChart(string cha, float s)
        {
            Chart chart = null;
            if (cha.Equals("Circle"))
            {
                chart = new Circle(s);
            }
            else if (cha.Equals("Square"))
            {
                chart = new Square(s);
            }
            return chart;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Chart chart;
            chart = Factory.GetChart("Circle",2,1);
            chart.Area();
            chart.Display();
        }
    }
}
