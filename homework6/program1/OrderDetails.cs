﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program1
{
    [Serializable]
     public class OrderDetails//订单明细/条目
    {
        public OrderDetails()
        {

        }
        public OrderDetails(Goods goods,int number)
        {
            this.CommodityNumber = number;
            this.good = goods;
            this.TotalPrice = this.good.Price * this.CommodityNumber;
        }
        public Goods good { set; get; }
        public int DetailsNumber { set; get; }//明细序号      
        public float TotalPrice { set; get; }//商品总价格

        public int CommodityNumber { set; get; }//商品数量(外部传入)            
    }
}
