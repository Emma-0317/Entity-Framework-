using Entity_Framework練習題.Models;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            addData();
        }

        private void addData()
        {
            var contect = new ContactsModel1();
            var list = contect.Product.ToList();
            dataGridView1.DataSource = list;
        }

        private void button3_Click(object sender, EventArgs e)//新增資料
        {
            Product data = new Product()
            {
                Id = textBox1.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Quantity = textBox3.Text.Trim(),
                Price = textBox4.Text.Trim(),
                Type = textBox5.Text.Trim(),
            };
            try
            {
                ContactsModel1 context = new ContactsModel1();
                context.Product.Add(data);
                context.SaveChanges();
                addData();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex) { MessageBox.Show($"發生錯誤{ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)//修改資料
        {
            try
            {
                var productId = dataGridView1.SelectedRows[1].Cells[0].Value.ToString();
                using (ContactsModel1 context = new ContactsModel1())
                {
                    var product = context.Product.FirstOrDefault((x) => x.Id == productId);
                    if (product == null)
                    {
                        MessageBox.Show("找不到該項商品");
                        return;
                    }
                    product.Name = textBox2.Text;
                    product.Quantity = textBox3.Text;
                    product.Price = textBox4.Text;
                    product.Type = textBox5.Text;
                    context.SaveChanges();
                    addData();
                    MessageBox.Show("存檔完成");
                    ClearTextBoxes();
                }
            }
            catch (Exception ex) { MessageBox.Show($"修改失敗{ex.ToString()}"); }
        }

        private void button4_Click(object sender, EventArgs e)//刪除資料
        {
            try
            {
                var productId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                using (ContactsModel1 context = new ContactsModel1())
                {
                    var product = context.Product.FirstOrDefault((x) => x.Id == productId);
                    if (product == null)
                    {
                        MessageBox.Show("找不到該項商品");
                        return;
                    }
                    context.Product.Remove(product);
                    context.SaveChanges();
                    addData();
                    MessageBox.Show("刪除完成");
                    ClearTextBoxes();
                }

            }
            catch (Exception ex) { MessageBox.Show($"刪除失敗{ex.ToString()}"); }
        }

        private void button2_Click(object sender, EventArgs e)//所有產品
        {
            var form = new Form();
            form.Show();
        }


        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
