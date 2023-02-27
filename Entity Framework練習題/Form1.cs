using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework練習題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//新增商品
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//修改商品
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//刪除商品
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//查詢特定商品
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//所有商品
        {
            var form = new Form();
            form.Show();
        }
    }
}
