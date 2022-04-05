using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TacoShop
{
    public partial class ReceiptForm : Form
    {
        connectionObject con = new connectionObject();
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            receiptBox.Items.Clear();
            String s = con.lookupReceipt(searchInput.Text); //Looks up receipt with the ID value of what is in the text box
            receiptBox.Items.Add(s);
        }
    }
}
