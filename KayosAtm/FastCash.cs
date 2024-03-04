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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTable where AccountNumber='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Bakiyeniz: "+ dt.Rows[0][0].ToString() + "TL";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }

        private void addTransactionToTable20()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 20 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTransactionToTable50()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 50 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTransactionToTable100()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 100 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTransactionToTable200()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 200 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTransactionToTable500()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTransactionToTable1000()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bal < 20)
            {
                MessageBox.Show("Yetersiz bakiye.");
            } else
            {
                int newBalance = bal - 20;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable20();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 200)
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
            else
            {
                int newBalance = bal - 200;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable200();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 50)
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
            else
            {
                int newBalance = bal - 50;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable50();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
            else
            {
                int newBalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable500();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
            else
            {
                int newBalance = bal - 100;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable100();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
            else
            {
                int newBalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paranız başarıyla çekilmiştir.");
                    Con.Close();
                    addTransactionToTable1000();
                    HOME home = new HOME();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
