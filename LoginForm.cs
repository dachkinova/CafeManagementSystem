using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CafeManagementSystem.Properties;
using MySql.Data;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;

namespace HotelMenagementSystem
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string dbPath = Application.StartupPath + "\\Log-in-form.mdf";

            SqlConnection connection = new SqlConnection
                   (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath +
                   ";Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter
                ("Select Count (*) From dbo.[Table] where Username='" +
                textBoxUsername.Text + "' and Password ='" +
                textBoxPassword.Text + "'", connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string userName = textBoxUsername.Text;
                this.Hide();
                Form1 form = new Form1(userName);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username/Password not correct",
                "Cafe management system");
                textBoxUsername.Clear();
                textBoxPassword.Clear();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var binFormatter = new BinaryFormatter();
            FileStream f = File.Open(@"D:\messageNote.txt",
                FileMode.Create, FileAccess.Write);

            binFormatter.Serialize(f, textBoxNote.Text);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
