using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SE_Assignment
{
    public partial class SignUp : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\nishant\Desktop\CodeRepo\Code-repository\SE Assignment\testlogin.mdf';Integrated Security=True;Connect Timeout=30";

        public SignUp()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (unameSignUp.Text == "")
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unameSignUp.Focus();
                return;
            }
            if (passSignUp.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passSignUp.Focus();
                return;
            }
            if(passSignUp.Text!=passConf.Text)
            {
                MessageBox.Show("Passwords Entered are not same, please enter again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passSignUp.Clear();
                passConf.Clear();
                passSignUp.Focus();
                return;
            }
            try
            {
                using (SqlConnection signupCon = new SqlConnection(cs))
                { 
                    signupCon.Open();
                    using (SqlCommand signupCom = new SqlCommand("insert into login ([username], [password], [SeQue], [SeAns]) values(@uname,@pass,@sequ,@sean)", signupCon))
                    {
                        signupCom.Parameters.AddWithValue("@uname", unameSignUp.Text);
                        signupCom.Parameters.AddWithValue("@pass", passSignUp.Text);
                        signupCom.Parameters.AddWithValue("@sequ", secQueDrop.Text);
                        signupCom.Parameters.AddWithValue("@sean", secAnsBox.Text);
                        signupCom.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully","Successful", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {


        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
