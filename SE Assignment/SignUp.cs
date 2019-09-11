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

namespace SE_Assignment
{
    public partial class SignUp : Form
    {
        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='N:\nishant\Desktop\GhatiaHub-master (1)\GhatiaHub-master\SE Assignment\testlogin.mdf';Integrated Security = True; Connect Timeout = 30";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection signupCon = new SqlConnection(cs);
            SqlCommand signupCom = new SqlCommand("insert into Main ([Username], [Password], [Security Question], [Security Answer]) values(@username,@password,@SeQue,@SeAns)", signupCon);
            signupCom.CommandType = CommandType.StoredProcedure;
            signupCom.Parameters.AddWithValue("@username", textBox1.Text);
            if (textBox5.Text == textBox2.Text)
                signupCom.Parameters.AddWithValue("@password", textBox2.Text);
            else
            {
                MessageBox.Show("Please Check Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return;
            }
            signupCom.Parameters.AddWithValue("@SeQue", comboBox1.Text);
            signupCom.Parameters.AddWithValue("@SeAns", textBox4.Text);
            signupCon.Open();
            int i = signupCom.ExecuteNonQuery();

            signupCon.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
