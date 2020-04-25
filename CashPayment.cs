using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMenagementSystem
{
    public partial class CashPayment : Form
    {
        public CashPayment(string totalBill)
        {
            //total3.Text = totalBill;
            InitializeComponent();
            total3.Text = totalBill;
        }

        private void total3_TextChanged(object sender, EventArgs e)
        {

        }

        private double Change()
        {
            double change = double.Parse(payingAmountBox.Text) -
                double.Parse(total3.Text);
            return change;
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("The return amount is: "+ Change().ToString());
        }
    }
}
