using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace SE_Assignment
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
          
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
         
            string a, b;
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter The Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter The Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox2.Focus();
                return;
            }
            try
            {
                a = comboBox1.SelectedItem.ToString();
                b = comboBox2.SelectedItem.ToString();
                if (a == "Fibonacci Series" && b == "C")
                {
                    TextReader reader = new StreamReader("fibinc.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Fibonacci Series" && b == "C++")
                {
                    TextReader reader = new StreamReader("fibincpp.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Fibonacci Series" && b == "Python")
                {
                    TextReader reader = new StreamReader("fibo.py");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Fibonacci Series" && b == "Java")
                {
                    TextReader reader = new StreamReader("fiboinja.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Factorial Of A Number" && b == "C")
                {
                    TextReader reader = new StreamReader("factinc.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Factorial Of A Number" && b == "C++")
                {
                    TextReader reader = new StreamReader("factincpp.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Factorial Of A Number" && b == "Python")
                {
                    TextReader reader = new StreamReader("fact.py");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Factorial Of A Number" && b == "Java")
                {
                    TextReader reader = new StreamReader("factinja.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Calculator" && b == "C")
                {
                    TextReader reader = new StreamReader("calcinc.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Calculator" && b == "C++")
                {
                    TextReader reader = new StreamReader("calcincpp.txt");
                    richTextBox1.Text = reader.ReadToEnd();

                }
                else if (a == "Calculator" && b == "Python")
                {
                    TextReader reader = new StreamReader("calc.py");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Calculator" && b == "Java")
                {
                    TextReader reader = new StreamReader("calcinja.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Banking System" && b == "C")
                {
                    TextReader reader = new StreamReader("bankinc.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Banking System" && b == "C++")
                {
                    TextReader reader = new StreamReader("bankincpp.txt");
                    richTextBox1.Text = reader.ReadToEnd();

                }
                else if (a == "Banking System" && b == "Python")
                {
                    TextReader reader = new StreamReader("bank.py");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Banking System" && b == "Java")
                {
                    TextReader reader = new StreamReader("bankinja.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Linked List" && b == "C")
                {
                    TextReader reader = new StreamReader("llinc.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Linked List" && b == "C++")
                {
                    TextReader reader = new StreamReader("llincpp.txt");
                    richTextBox1.Text = reader.ReadToEnd();

                }
                else if (a == "Linked List" && b == "Python")
                {
                    TextReader reader = new StreamReader("list.py");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Linked List" && b == "Java")
                {
                    TextReader reader = new StreamReader("llinja.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            string a, b;
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter The Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter The Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox2.Focus();
                return;
            }
            try
            {
                a = comboBox1.SelectedItem.ToString();
                b = comboBox2.SelectedItem.ToString();
                if (a == "Fibonacci Series" && b == "C")
                {
                    Process.Start("fibinc.exe");
                }
                else if (a == "Fibonacci Series" && b == "C++")
                {
                    Process.Start("fibincpp.exe");
                }
                else if (a == "Fibonacci Series" && b == "Python")
                {
                    Process.Start("fibo.py");
                }

                else if (a == "Factorial Of A Number" && b == "C")
                {
                    Process.Start("factinc.exe");
                }
                else if (a == "Factorial Of A Number" && b == "C++")
                {
                    Process.Start("factincpp.exe");
                }
                else if (a == "Factorial Of A Number" && b == "Python")
                {
                    Process.Start("fact.py");
                }
                else if (a == "Calculator" && b == "C")
                {
                    Process.Start("calcinc.exe");
                }
                else if (a == "Calculator" && b == "C++")
                {
                    Process.Start("calcincpp.exe");
                }
                else if (a == "Calculator" && b == "Python")
                {
                    Process.Start("calc.py");
                }

                else if (a == "Banking System" && b == "C")
                {
                    Process.Start("bankinc.exe");
                }
                else if (a == "Banking System" && b == "Python")
                {
                    Process.Start("bank.py");
                }
                
              
                else if (a == "Linked List" && b == "C")
                {
                    Process.Start("llinc.exe");
                }
                else if (a == "Linked List" && b == "C++")
                {
                    Process.Start("llincpp.exe");
                }
                else if (a == "Linked List" && b == "Python")
                {
                    Process.Start("list.py");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Java")
                button4.Enabled = false;
            else
                button4.Enabled = true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
