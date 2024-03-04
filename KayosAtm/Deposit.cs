using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayosAtm
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");

        int oldBalance, newBalance;
        string Acc = Login.AccNumber;

        private void addTransactionToTable()
        {
            string TransactionType = "Para Yatırma";
            try
            {
                
                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + DepositAmountTb.Text+ ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTable where AccountNumber='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DepositAmountTb.Text == "" || Convert.ToInt32(DepositAmountTb.Text) <= 0)
            {
                MessageBox.Show("Yatırılacak miktarı giriniz.");
            } else if(Convert.ToInt32(DepositAmountTb.Text) > 185000) {
                MessageBox.Show("Tek seferde 185000TL'den fazla yatıramazsınız.");
            } else
            {
                
                newBalance = oldBalance + Convert.ToInt32(DepositAmountTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla yatırılmıştır.");
                    Con.Close();
                    addTransactionToTable();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                } catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DepositAmountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
