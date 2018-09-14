using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //改进1
            bool T = true;
            while (T)
            {
                
                try
                {
                    double num1 = Int32.Parse(textBox1.Text);
                    double num2 = Int32.Parse(textBox2.Text);
                    double pro = num1 * num2;
                    textBox3.Text = Convert.ToString(pro);
                    T = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("请正确输入数字！");
                    textBox1.Text = "0";
                    textBox2.Text = "0";
                    T = true;
                }
                
            }

            //double num1 = Int32.Parse(textBox1.Text);
            //double num2 = Int32.Parse(textBox2.Text);
            //double pro = num1 * num2;
            //textBox3.Text = Convert.ToString(pro);

        }
    }
}
