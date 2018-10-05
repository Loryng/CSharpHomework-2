using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order a = new Order();
            
            OrderService.Add(a.MyOreder, 1, "2", 12, 12, "W");
            OrderService.Add(a.MyOreder, 2, "2", 12, 12, "W");
            OrderService.Add(a.MyOreder, 3, "2", 12, 12, "W");
            OrderService.Add(a.MyOreder, 4, "2", 12, 12, "W");
            OrderService.Add(a.MyOreder, 5, "2", 12, 12, "W");
        }
    }
}
