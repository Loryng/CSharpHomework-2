using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Goods
    {
        public Goods(string goods)
        {
            if (goods.Equals("辣条"))
            {
                this.Id = "2018101301";
                this.Price = 0.5F;
                this.Name = goods;
            }
            else if (goods.Equals("七个小矮人"))
            {
                this.Id = "2018101302";
                this.Price = 1.0f;
                this.Name = goods;
            }
            else if (goods.Equals("快乐水"))
            {
                this.Id = "2018101303";
                this.Price = 3.0f;
                this.Name = goods;
            }
            else
            {
                throw new Exception("没有此商品");
            }            
        }

        public string Id
        {
            get;

        }
        public float Price
        {
            get;
        }
        public string Name
        {
            get;
        }
        
    }
}
