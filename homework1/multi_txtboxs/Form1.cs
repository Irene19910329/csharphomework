using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_txtboxs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 求积_Click(object sender, EventArgs e)
        {
            double num1, num2;
            try
            {
                num1 = double.Parse(this.textBox1.Text);
                num2 = double.Parse(this.textBox2.Text);
                MessageBox.Show("" + num1 + "*" + num2 + "=" + (num1 * num2), "计算结果");
            }
            catch (Exception)
            {
                MessageBox.Show("计算失败！请输入合法数字进行运算。", "错误");
            }
        }
    }
}
