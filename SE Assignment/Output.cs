using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //to be linked to the previous page 
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
                    TextReader reader = new StreamReader("fibinpy.txt");
                    richTextBox1.Text = reader.ReadToEnd();
                }
                else if (a == "Fibonacci Series" && b == "Java")
                {
                    TextReader reader = new StreamReader("fibinja.txt");
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
                    TextReader reader = new StreamReader("factinpy.txt");
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
                    TextReader reader = new StreamReader("calcinpy.txt");
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
                    TextReader reader = new StreamReader("bankinpy.txt");
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
                    TextReader reader = new StreamReader("llinpy.txt");
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
                if (b == "Java" || b == "Python")
                {
                    MessageBox.Show("Program not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (a == "Fibonacci Series" && b == "C")
                {
                    Process.Start("fibinc.exe");
                }
                else if (a == "Fibonacci Series" && b == "C++")
                {
                    Process.Start("fibincpp.exe");
                }
                else if (a == "Factorial Of A Number" && b == "C")
                {
                    Process.Start("factinc.exe");
                }
                else if (a == "Factorial Of A Number" && b == "C++")
                {
                    Process.Start("factincpp.exe");
                }
                
                else if (a == "Calculator" && b == "C")
                {
                    Process.Start("calcinc.exe");
                }
                else if (a == "Calculator" && b == "C++")
                {
                    Process.Start("calcincpp.exe");
                }
                 else if (a == "Banking System" && b == "C")
                {
                    Process.Start("bankinc.exe");
                }
                else if (a == "Banking System" && b == "C++")
                {
                    Process.Start("bankincpp.exe");
                }
                
                else if (a == "Linked List" && b == "C")
                {
                    Process.Start("llinc.exe");
                }
                else if (a == "Linked List" && b == "C++")
                {
                    Process.Start("llincpp.exe");
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

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
