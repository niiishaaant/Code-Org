using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SE_Assignment
{
    public partial class Login : Form
    {
        
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Shreeyash Naik\Documents\GitHub\Code-Repository\SE Assignment\testlogin.mdf';Integrated Security = True; Connect Timeout = 30";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameBox.Focus();
        }
        Output op = new Output();
        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Focus();
                return;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordBox.Focus();
                return;
            }
            try
            {
                SqlConnection loginCon = default(SqlConnection);
                loginCon = new SqlConnection(cs);

                SqlCommand loginCom = default(SqlCommand);
                loginCom = new SqlCommand("SELECT Username,Password FROM login WHERE Username = @username AND Password = @password", loginCon);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPass = new SqlParameter("@Password", SqlDbType.VarChar);
                uName.Value = usernameBox.Text;
                uPass.Value = passwordBox.Text;


                loginCom.Parameters.Add(uName);
                loginCom.Parameters.Add(uPass);

                loginCom.Connection.Open();

                SqlDataReader loginRead = loginCom.ExecuteReader(CommandBehavior.CloseConnection);

                if (loginRead.Read() == true)
                { 
                    op.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (loginCon.State == ConnectionState.Open)
                    loginCon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forgot fo = new Forgot();
            fo.Show();
            this.Close();
        }
    }
}
