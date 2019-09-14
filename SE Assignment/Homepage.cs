using System;
using System.Windows.Forms;

namespace SE_Assignment
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        SignUp ss = new SignUp();
        Login mm = new Login();
        private void button1_Click(object sender, EventArgs e)
        {
            mm.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        { 
            ss.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
