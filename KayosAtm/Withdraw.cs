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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;

        int bal, newBalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTable where AccountNumber='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Bakiyeniz: " + dt.Rows[0][0].ToString() + "TL";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();
        }
        private void addTransactionToTable()
        {
            string TransactionType = "Para Çekme";
            try
            {

                Con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TransactionType + "'," + withdrawAmountTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void withdrawAmountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void withdrawAmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawAmountTb.Text == "")
            {
                MessageBox.Show("Geçerli bir miktar giriniz.");
            } else if (Convert.ToInt32(withdrawAmountTb.Text) <= 0)
            {
                MessageBox.Show("Yetersiz bakiye.");
            } else if (Convert.ToInt32(withdrawAmountTb.Text) > bal)
            {
                MessageBox.Show("Girdiğiniz miktar bakiyenizden büyük olamaz.");
            } else if (Convert.ToInt32(withdrawAmountTb.Text) > 10000)
            {
                MessageBox.Show("Tek seferde 10000TL'den fazla çekemezsiniz.");
            } else
            {
                try
                {
                    newBalance = bal - Convert.ToInt32(withdrawAmountTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTable set Balance =" + newBalance + " where AccountNumber='" + Acc + "' ";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paranız başarıyla çekilmiştir.");
                        Con.Close();
                        addTransactionToTable();
                        HOME home = new HOME();
                        this.Hide();
                        home.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }
        }
    }
