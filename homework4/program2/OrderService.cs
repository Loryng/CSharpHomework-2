using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program2
{
    class OrderService
    {
        List<OrderDetails> MyOreder = new List<OrderDetails>();
        //（订单明细，编号，名称，数量，价格，客户）
        public static void Add(List<OrderDetails> a,int b,string c,int d,float e,string f) //（订单明细，编号，名称，数量，价格，客户）
        {
            OrderDetails NewOrderDetails = new OrderDetails();
            NewOrderDetails.CommodityID = b;
            NewOrderDetails.CommodityName = c;
            NewOrderDetails.CommodityNumber = d;
            NewOrderDetails.CommodityPrice = e;
            NewOrderDetails.Client = f;
            a.Add(NewOrderDetails);
        } 
        public static void Delete()
        {

        }
        public static void Search()
        {

        }
        public static void ShowWrong()
        {

        }
    }
}
