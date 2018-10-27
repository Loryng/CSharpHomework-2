using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
 
            InitializeComponent();
        }
        private static int m = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Goods goods1=null,goods2=null,goods3=null;
            m++;
            Order order = new Order();
            int B = 0;
            if(checkBox1.Checked&&textBox2!=null)
            {
               goods1 = new Goods("辣条");
                OrderDetails orderDetails = new OrderDetails(goods1, Convert.ToInt32(textBox2.Text));
                B++;
                orderDetails.DetailsNumber = B;
                order.MyOrder.Add(orderDetails);
            }
            if (checkBox2.Checked && textBox3 != null)
            {
                goods2 = new Goods("快乐水");
                OrderDetails orderDetails = new OrderDetails(goods2, Convert.ToInt32(textBox3.Text));
                B++;
                orderDetails.DetailsNumber = B;
                order.MyOrder.Add(orderDetails);
            }
            if (checkBox3.Checked && textBox4 != null)
            {
                goods3 = new Goods("七个小矮人");
                OrderDetails orderDetails = new OrderDetails(goods3, Convert.ToInt32(textBox4.Text));
                B++;
                orderDetails.DetailsNumber = B;
                order.MyOrder.Add(orderDetails);
            }
            order.Client = textBox1.Text;
            order.OrderId = m +DateTime.Now.Month*10000+DateTime.Now.Day*100;
            order.Sum();
            Form1.os.AddOrder(order);
            this.Close();
        }
    }
}
