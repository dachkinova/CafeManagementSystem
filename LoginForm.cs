using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
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
            var binFormatter = new BinaryFormatter();
            FileStream f = File.Open(@"D:\messageNote.txt",
                FileMode.Create, FileAccess.Write);

            binFormatter.Serialize(f, textBoxNote.Text);
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
            if (File.Exists(@"D:\messageNote.txt"))
            {
                var binFormatter = new BinaryFormatter();
                using (var fileStream = new FileStream(@"D:\messageNote.txt",
                   FileMode.Open, FileAccess.Read))
                {
                    textBoxNote.Text = (string)binFormatter.Deserialize(fileStream);
                }
            }
            else
            {
                return;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
