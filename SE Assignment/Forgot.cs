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
    public partial class Forgot : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='N:\nishant\Desktop\CodeRepo\Code-repository\SE Assignment\testlogin.mdf';Integrated Security=True;Connect Timeout=30";
        public Forgot()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forgot_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            try
            {
                SqlConnection loginCon = default(SqlConnection);
                loginCon = new SqlConnection(cs);

                SqlCommand loginCom = default(SqlCommand);
                loginCom = new SqlCommand("SELECT Username, SeQue, SeAns FROM login WHERE Username = @username AND Seque = @seque AND seans = @seans", loginCon);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter se = new SqlParameter("@seque", SqlDbType.NVarChar);
                SqlParameter sea = new SqlParameter("@seans", SqlDbType.NVarChar);
                uName.Value = textBox1.Text;
                se.Value = textBox2.Text;
                sea.Value = textBox3.Text;


                loginCom.Parameters.Add(uName);
                loginCom.Parameters.Add(se);
                loginCom.Parameters.Add(sea);
                loginCom.Connection.Open();

                SqlDataReader loginRead = loginCom.ExecuteReader(CommandBehavior.CloseConnection);

                if (loginRead.Read() == true)
                {
                    Output op = new Output();
                    op.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Security Question and Answer is wrong", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (loginCon.State == ConnectionState.Open)
                    loginCon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
