using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayosAtm
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Hesap Numarası: " + Login.AccNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FastCash fcash = new FastCash();
            fcash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.Show();
            this.Hide();
        }

        private void AccNumlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
