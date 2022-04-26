using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TacoShop1;

namespace TacoShop
{
    public partial class Form1 : Form
    {
        connectionObject con = new connectionObject();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {

            if (PasswordTextBox.Text != "")
            {
                if(PasswordTextBox.Text == ReEnterPasswordTextBox.Text)
                {
                    int admincheck = 0;
                    if (AdminCheckBox.Checked)
                    {
                        admincheck = 1;
                    }
                    con.CreateUser(NameTextBox.Text, UserTextBox.Text, PasswordTextBox.Text, admincheck);

                    MessageBox.Show("User " + UserTextBox.Text + " Created!", "Success");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords dont match.", "Error.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Password.", "Error.");
            }
        }
    }
}
