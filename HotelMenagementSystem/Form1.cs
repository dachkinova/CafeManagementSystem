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
    public partial class Form1 : Form
    {
        private List<Product> coffes;
        public Form1()
        {
            coffes = new List<Product>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOut = new CheckOutForm();
            checkOut.ShowDialog();
        }

      

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFruitTea.Checked == true)
            {
                textBoxFruitTea.Enabled = true;
                textBoxFruitTea.Text = "";
                textBoxFruitTea.Focus();
            }
            else
            {
                textBoxFruitTea.Enabled = false;
                textBoxFruitTea.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbGreenTea.Checked == true)
            {
                textBoxGreenTea.Enabled = true;
                textBoxGreenTea.Text = "";
                textBoxGreenTea.Focus();
            }
            else
            {
                textBoxGreenTea.Enabled = false;
                textBoxGreenTea.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLemonade.Checked == true)
            {
                textBoxLemonade.Enabled = true;
                textBoxLemonade.Text = "";
                textBoxLemonade.Focus();
            }
            else
            {
                textBoxLemonade.Enabled = false;
                textBoxLemonade.Text = "0";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit the system?", "Cafe management system", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestTextBoxes();
            EnableTextBoxes();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit the system?", "Cafe management system",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> function = null;

            function = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "0";
                    }
                    else
                    {
                        function(control.Controls);
                    }
                }
            };
            function(Controls);
        }

        

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> function = null;

            function = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Enabled = false;
                    }
                    else
                    {
                        function(control.Controls);
                    }
                }
            };
            function(Controls);
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            listView1.Clear();
            
            coffes.Clear();
            
        }

        private void cbHerbTea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHerbTea.Checked == true)
            {
                textBoxHerbTea.Enabled = true;
                textBoxHerbTea.Text = "";
                textBoxHerbTea.Focus();
            }
            else
            {
                textBoxHerbTea.Enabled = false;
                textBoxHerbTea.Text = "0";
            }
        }

        private void cbCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCappuccino.Checked == true)
            {
                textBoxCappuccino.Enabled = true;
                textBoxCappuccino.Text = "";
                textBoxCappuccino.Focus();
            }
            else
            {
                textBoxCappuccino.Enabled = false;
                textBoxCappuccino.Text = "0";
            }
        }

        private void cbCafeLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCafeLatte.Checked == true)
            {
                textBoxCafeLatte.Enabled = true;
                textBoxCafeLatte.Text = "";
                textBoxCafeLatte.Focus();
            }
            else
            {
                textBoxCafeLatte.Enabled = false;
                textBoxCafeLatte.Text = "0";
            }
        }

        private void cbMocaccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMocaccino.Checked == true)
            {
                textBoxMocaccino.Enabled = true;
                textBoxMocaccino.Text = "";
                textBoxMocaccino.Focus();
            }
            else
            {
                textBoxMocaccino.Enabled = false;
                textBoxMocaccino.Text = "0";
            }
        }

        private void cbHotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHotChocolate.Checked == true)
            {
                textBoxHotChocolate.Enabled = true;
                textBoxHotChocolate.Text = "";
                textBoxHotChocolate.Focus();
            }
            else
            {
                textBoxHotChocolate.Enabled = false;
                textBoxHotChocolate.Text = "0";
            }
        }

        private void cbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWater.Checked == true)
            {
                textBoxWater.Enabled = true;
                textBoxWater.Text = "";
                textBoxWater.Focus();
            }
            else
            {
                textBoxWater.Enabled = false;
                textBoxWater.Text = "0";
            }
        }

        private void cbSoftDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoftDrink.Checked == true)
            {
                textBoxSoftDrink.Enabled = true;
                textBoxSoftDrink.Text = "";
                textBoxSoftDrink.Focus();
            }
            else
            {
                textBoxSoftDrink.Enabled = false;
                textBoxSoftDrink.Text = "0";
            }
        }

        private void cbIcedTea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIcedTea.Checked == true)
            {
                textBoxIcedTea.Enabled = true;
                textBoxIcedTea.Text = "";
                textBoxIcedTea.Focus();
            }
            else
            {
                textBoxIcedTea.Enabled = false;
                textBoxIcedTea.Text = "0";
            }
        }

        private void cbIcedCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIcedCoffee.Checked == true)
            {
                textBoxIcedCoffee.Enabled = true;
                textBoxIcedCoffee.Text = "";
                textBoxIcedCoffee.Focus();
            }
            else
            {
                textBoxIcedCoffee.Enabled = false;
                textBoxIcedCoffee.Text = "0";
            }
        }

        private void cbSmoothie_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSmoothie.Checked == true)
            {
                textBoxSmoothie.Enabled = true;
                textBoxSmoothie.Text = "";
                textBoxSmoothie.Focus();
            }
            else
            {
                textBoxSmoothie.Enabled = false;
                textBoxSmoothie.Text = "0";
            }
        }

        private void cbMilkshake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMilkshake.Checked == true)
            {
                textBoxMilkshake.Enabled = true;
                textBoxMilkshake.Text = "";
                textBoxMilkshake.Focus();
            }
            else
            {
                textBoxMilkshake.Enabled = false;
                textBoxMilkshake.Text = "0";
            }
        }

        private void cbFreshJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFreshJuice.Checked == true)
            {
                textBoxFreshJuice.Enabled = true;
                textBoxFreshJuice.Text = "";
                textBoxFreshJuice.Focus();
            }
            else
            {
                textBoxFreshJuice.Enabled = false;
                textBoxFreshJuice.Text = "0";
            }
        }

       

        private void textBoxChocoCake_TextChanged(object sender, EventArgs e)
        {

        }

       
       

        private void textBoxEspresso_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCapuchino_Click(object sender, EventArgs e)
        {
            Cappuccino cap = new Cappuccino();
            this.coffes.Add(cap);
            ShowInformation(this, null);
            listView1.Items.Add(cap.ToString());
        }
        private void ShowInformation(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Bill:");
            foreach (Product coffee in coffes)
            {
                builder.AppendLine(coffee.ToString());
            }
            builder.AppendLine();
            
            TotalBill.Text = (string.Format("Total bill: {0}", coffes.Sum(x => x.GetTotalPrice)));
            //Result.Text = builder.ToString();
        }
    }
}
