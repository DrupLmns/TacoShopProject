﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TacoShop;

namespace TacoShop1
{
    public partial class MainForm : Form
    {
        connectionObject con = new connectionObject();

        Form receipt = new ReceiptForm();

        string s;

        public MainForm()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TacoButton_Click(object sender, EventArgs e)
        {
            s = con.returnFoodItem("getTaco");
            ReceiptBox.Items.Add(s);
            
        }
        private void BurritoButton_Click(object sender, EventArgs e)
        {
            s = con.returnFoodItem("getBurrito");
            ReceiptBox.Items.Add(s);
        }
        private void WaterButton_Click(object sender, EventArgs e)
        {
            s = con.returnFoodItem("getWater");
            ReceiptBox.Items.Add(s);
        }
        private void SodaButton_Click(object sender, EventArgs e)
        {
            s = con.returnFoodItem("getSoda");
            ReceiptBox.Items.Add(s);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReceiptBox.Items.Clear();
        }

        private void create_receipt_button_Click(object sender, EventArgs e)
        {
        }
        private void view_receipts_button_Click(object sender, EventArgs e)
        {
            receipt.Show(this);
        }
    }
}
