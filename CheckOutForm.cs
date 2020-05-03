using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Printing;
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

        public string totalBill1 { get; private set; }

        public CheckOutForm(string totalBill, List<Product> productsList)
        {
            InitializeComponent();
            ListViewItem list = new ListViewItem(Name);
            this.totalBill1 = totalBill;
            textBox3.Text = totalBill1;
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
                    TotalPrice = string.Format("{0:f2}", g.Sum(s => s.Price * s.quantity)) })
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
            Form1 f = new Form1();
            
            foreach (var pr in productsList1)
            {
                listView1.Items.Add(pr.ToString());
                ShowInformation(this, null);
            }
            f.ShowDialog();
            this.Hide();
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
            totalBill1 = textBox3.Text;
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                PaymentMethod pm = new ByCash(totalBill1);
                pm.ShowMessage();

            }
            else if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                
                PaymentMethod pm = new WithCard(totalBill1);
                pm.ShowMessage();
            }
        }
        public void ShowInformation(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            //builder.AppendLine("Bill:");
            foreach (Product pr in productsList1)
            {
                builder.AppendLine(pr.ToString());
            }
            builder.AppendLine();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.PaperSize = 
                new PaperSize("", 390, 500);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.PrintPreviewControl.Zoom = 1.0;
            printPreviewDialog.ShowDialog();
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RECEIPT", new Font("Times New Roman", 20,  FontStyle.Underline), 
                new SolidBrush(Color.Blue), new Point(45, 45));
            
            e.Graphics.DrawString("Cafe management system", new Font("Times New Roman", 12, FontStyle.Italic),
                new SolidBrush(Color.Black), new Point(45, 100));

            

            e.Graphics.DrawString("Item", new Font("Times New Roman", 11, FontStyle.Italic),
            new SolidBrush(Color.Black), new Point(45, 130));
            e.Graphics.DrawString("Quantity", new Font("Times New Roman", 11, FontStyle.Italic),
            new SolidBrush(Color.Black), new Point(200, 130));
            e.Graphics.DrawString("Price", new Font("Times New Roman", 11, FontStyle.Italic),
            new SolidBrush(Color.Black), new Point(300, 130));

            int x = 150;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string name = listView1.Items[i].Text;
                string qty = listView1.Items[i].SubItems[1].Text;
                string price = listView1.Items[i].SubItems[2].Text;


                e.Graphics.DrawString(name, new Font("Times New Roman", 12),
                new SolidBrush(Color.Black), new Point(45, x));
                e.Graphics.DrawString(qty, new Font("Times New Roman", 12),
                new SolidBrush(Color.Black), new Point(200, x));
                e.Graphics.DrawString(price, new Font("Times New Roman", 12),
                new SolidBrush(Color.Black), new Point(300, x));
                
                x += 17;
                

            }
            
                e.Graphics.DrawString("----------------------------",
                    new Font("Times New Roman", 11, FontStyle.Italic),
                new SolidBrush(Color.Black), new Point(200, x+20));
                e.Graphics.DrawString("Total bill: " + totalBill1, new Font("Times New Roman", 14, FontStyle.Italic),
                new SolidBrush(Color.Black), new Point(210, x+40));

            var dateTime = DateTime.Now;
            e.Graphics.DrawString(dateTime.ToString(), new Font("Times New Roman", 11, FontStyle.Italic),
            new SolidBrush(Color.Black), new Point(45, x+100));



        }

        private void printPreview_PrintClick(object sender, System.EventArgs ee)
        {
            try
            {
                this.printPreviewDialog.Document = printDocument;
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                } 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }
        }

    }
    }

    
