﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program2
{
    class OrderDetails//订单明细/条目
    {      
        public int CommodityID { set; get; }//商品编号
        public string CommodityName { set; get; }//商品名称
        public int CommodityNumber { set; get; }//商品数量
        public float CommodityPrice { set; get; }//商品价格
        public string Client { set; get; }//客户      
    }
}
