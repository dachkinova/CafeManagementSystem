using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMenagementSystem
{
    [Serializable]
    public partial class Form1 : Form
    {
        public string userName1 { get; internal set; }
        public List<Product> productsList;
        public Form1(string userName)
        {
            this.userName1 = userName;
            productsList = new List<Product>();
            if (productsList != null)
            {
                foreach (var pr in productsList)
                {
                    listView1.Items.Add(pr.ToString());
                    ShowInformation(this, null);
                }
            }
            InitializeComponent();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var binFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream(@"D:\Ина\productsList.txt", 
                FileMode.Create, FileAccess.Write))
                binFormatter.Serialize(fileStream, productsList);
            
            CheckOutForm checkOut = new CheckOutForm(TotalBill.Text, productsList, false);
            this.Hide();
            checkOut.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //using (LoginForm login = new LoginForm())
            //{
                labelUser.Text = userName1;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Are you sure you want to exit " +
                "the system?", "Cafe management system",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            productsList.Clear();
        }
        private void BtnCapuchino_Click(object sender, EventArgs e)
        {
            Cappuccino cap = new Cappuccino();
            this.productsList.Add(cap);
            ShowInformation(this, null);
            listView1.Items.Add(cap.ToString());
            LastAddedItem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Espresso esp = new Espresso();
            this.productsList.Add(esp);
            ShowInformation(this, null);
            listView1.Items.Add(esp.ToString());
            LastAddedItem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CafeLatte cl = new CafeLatte();
            this.productsList.Add(cl);
            ShowInformation(this, null);
            listView1.Items.Add(cl.ToString());
            LastAddedItem();
        }

        private void btnMocaccino_Click(object sender, EventArgs e)
        {
            Mocaccino moc = new Mocaccino();
            this.productsList.Add(moc);
            ShowInformation(this, null);
            listView1.Items.Add(moc.ToString());
            LastAddedItem();
        }

        private void btnHotChocolate_Click(object sender, EventArgs e)
        {
            HotChocolate hotCh = new HotChocolate();
            this.productsList.Add(hotCh);
            ShowInformation(this, null);
            listView1.Items.Add(hotCh.ToString());
            LastAddedItem();
        }

        private void btnHerbTea_Click(object sender, EventArgs e)
        {
            HerbTea htea = new HerbTea();
            this.productsList.Add(htea);
            ShowInformation(this, null);
            listView1.Items.Add(htea.ToString());
            LastAddedItem();
        }

        private void btnGreenTea_Click(object sender, EventArgs e)
        {
            GreenTea gtea = new GreenTea();
            this.productsList.Add(gtea);
            ShowInformation(this, null);
            listView1.Items.Add(gtea.ToString());
            LastAddedItem();
        }

        private void btnFruitTea_Click(object sender, EventArgs e)
        {
            FruitTea ftea = new FruitTea();
            this.productsList.Add(ftea);
            ShowInformation(this, null);
            listView1.Items.Add(ftea.ToString());
            LastAddedItem();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            Water water = new Water();
            this.productsList.Add(water);
            ShowInformation(this, null);
            listView1.Items.Add(water.ToString());
            LastAddedItem();
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            SoftDrink sDrink = new SoftDrink();
            this.productsList.Add(sDrink);
            ShowInformation(this, null);
            listView1.Items.Add(sDrink.ToString());
            LastAddedItem();
        }

        private void btnIcedTea_Click(object sender, EventArgs e)
        {
            IcedTea itea = new IcedTea();
            this.productsList.Add(itea);
            ShowInformation(this, null);
            listView1.Items.Add(itea.ToString());
            LastAddedItem();
        }

        private void btnIcedCoffee_Click(object sender, EventArgs e)
        {
            IcedCoffee icoffee = new IcedCoffee();
            this.productsList.Add(icoffee);
            ShowInformation(this, null);
            listView1.Items.Add(icoffee.ToString());
            LastAddedItem();
        }

        private void btnSmoothie_Click(object sender, EventArgs e)
        {
            Smoothie sm = new Smoothie();
            this.productsList.Add(sm);
            ShowInformation(this, null);
            listView1.Items.Add(sm.ToString());
            LastAddedItem();
        }

        private void btnMilkShake_Click(object sender, EventArgs e)
        {
            MilkShake msh = new MilkShake();
            this.productsList.Add(msh);
            ShowInformation(this, null);
            listView1.Items.Add(msh.ToString());
            LastAddedItem();
        }

        private void btnFreshJuice_Click(object sender, EventArgs e)
        {
            FreshJuice fj = new FreshJuice();
            this.productsList.Add(fj);
            ShowInformation(this, null);
            listView1.Items.Add(fj.ToString());
            LastAddedItem();
        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {
            Lemonade lem = new Lemonade();
            this.productsList.Add(lem);
            ShowInformation(this, null);
            listView1.Items.Add(lem.ToString());
            LastAddedItem();
        }

        public void ShowInformation(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (Product pr in productsList)
            {
                builder.AppendLine(pr.ToString());
            }

            builder.AppendLine();

            TotalBill.Text = (string.Format("{0:f2}", 
                productsList.Sum(x => x.price)));
        }

        private void LastAddedItem ()
        {
            var current = productsList[productsList.Count - 1];

            toolStripStatusLabelCurrent.Text = 
                "Last added item:              " 
                + current;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
