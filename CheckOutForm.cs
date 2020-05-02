using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMenagementSystem
{
    public partial class CheckOutForm :Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        public List<Product> productsList1;

        public string totalBill { get; private set; }

        public CheckOutForm(string totalBill, List<Product> productsList)
        {
            InitializeComponent();
            ListViewItem list = new ListViewItem(Name);
            textBox3.Text = totalBill;
            this.productsList1 = productsList;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            label6.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();


            var list1 = productsList1.GroupBy(x => x.Name)
                .Distinct()
                .Select(g => new { Value = g.Key, 
                    Count = g.Count(), 
                    TotalPrice = g.Sum(s => s.Price * s.quantity) })
                .ToList();


            foreach (var x in list1)
            {
                ListViewItem lvi = new ListViewItem(x.Value.ToString());
                lvi.SubItems.Add(x.Count.ToString());
                lvi.SubItems.Add(x.TotalPrice.ToString());
                listView1.Items.Add(lvi);
            }
        }

        public CheckOutForm(string text)
        {
            Text = text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            foreach (var pr in productsList1)
            {
                listView1.Items.Add(pr.ToString());
            }
            f.ShowDialog();

            foreach(var pr in productsList1)
            {
                listView1.Items.Add(pr.ToString());
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.Items)
                if (item.Selected)
                {
                    listView1.Items.Remove(item);
                    
                    
                    double price = double.Parse(item.SubItems[2].Text);
                    double newPrice = double.Parse(this.textBox3.Text)-price;
                    textBox3.Text = newPrice.ToString();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            textBox3.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool IsDublicated () 
        {
            
            var q = productsList1.GroupBy(x => x)
               .Select(g => new { Value = g.Key, Count = g.Count() })
               .OrderByDescending(x => x.Count);

            return true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            totalBill = textBox3.Text;
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                PaymentMethod pm = new ByCash(totalBill);
                pm.ShowMessage();

            }
            else if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                
                PaymentMethod pm = new WithCard(totalBill);
                pm.ShowMessage();
            }
        }

       


    }

    }
