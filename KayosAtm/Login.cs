using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayosAtm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        public static String AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTable where AccountNumber='" + AccountNumberTb.Text + "' and Pin = " + PinTb.Text + "", Con);
            DataTable dt = new DataTable();
            if (AccountNumberTb.Text == "" || PinTb.Text == "") {
                MessageBox.Show("Bilgi kutucukları boş bırakılamaz.");
            } else {
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccNumber = AccountNumberTb.Text;
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                    Con.Close();
                } else
                {
                    MessageBox.Show("Bilgilerden en az bir tanesi yanlış, lütfen tekrar deneyin.");
                }
            }

            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AccountNumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
