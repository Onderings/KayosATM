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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onderings\Desktop\KayosAtm\KayosAtm\KayosAtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance() { 
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTable where AccountNumber='"+AccountNumberlbl.Text+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = dt.Rows[0][0].ToString() + "TL";
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccountNumberlbl.Text = Login.AccNumber;
            getBalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
