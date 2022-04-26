using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TacoShop1;

namespace TacoShop
{
    public partial class Login : Form
    {
        connectionObject con = new connectionObject();

        MainForm mainform = new MainForm();
        User user;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;

            user = con.GetUser(username,password);

            if(user.getName() != "ERROR")
            {
                mainform.LoadUser(user);
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No User found with username/password.", "Error.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
