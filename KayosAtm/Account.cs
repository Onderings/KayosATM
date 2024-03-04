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

namespace KayosAtm
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if(AccountNameTb.Text == "" || AccountNumberTb.Text == "" || SurNameTb.Text == "" || PhoneNumberTb.Text == "" || AddressTb.Text == "" || JobTb.Text == "" || PinTb.Text == "" || EducationTb.SelectedItem is null || AccountNumberTb.Text.Length < 11)
            {
                MessageBox.Show("Eksik veya hatalı bilgi girdiniz. Boş bıraktığınız kutucukları kontrol ediniz.");
            } else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTable values('" + AccountNumberTb.Text + "','" + AccountNameTb.Text + "','" + SurNameTb.Text + "','" + DateOfBirthTable.Value.Date + "','" + PhoneNumberTb.Text + "','" + AddressTb.Text + "','" + EducationTb.SelectedItem.ToString() + "','" + JobTb.Text + "'," + PinTb.Text + ","+balance+")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız oluşturuldu!");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountNumberTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountNumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void PinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
