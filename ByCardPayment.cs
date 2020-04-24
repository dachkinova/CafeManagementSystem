using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMenagementSystem
{
    public partial class ByCardPayment : Form
    {
        public ByCardPayment()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if (IsValidPassword()==true && IsValidID()==true)
            {
                MessageBox.Show("Transaction completed successfully! ");
            }
            else
            {
                MessageBox.Show("Wrong input! " + 
                    "ID should be 10 numbers long." +
                    "Password must contain at least 8 " +
                    "characters and at least one upper " +
                    "letter and one small letter!");
            }
        }
        public bool IsValidPassword()
        {
            string password = textBoxPassword.Text;
            if (password.Length > 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidID()
        {
            string id = textBoxID.Text;
            if (id.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
