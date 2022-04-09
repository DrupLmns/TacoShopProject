using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TacoShop
{
    public partial class ReceiptForm : Form
    {
        int cell = -1;
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
            receiptDataGrid.Rows.Clear();

            ArrayList s = con.lookupReceipt(searchInput.Text); //Looks up receipt with the ID value of what is in the text box
            int numRows;
            if (s.Count > 6)
            {
                numRows = s.Count / 6;
            }
            else
            {
                numRows = 1;
            }

            if (s.Count > 0)
            {
                for (int i = 0; i < numRows; i++)
                {
                    
                    
                    receiptDataGrid.Rows.Add(s[incramentCell()], s[incramentCell()], 

                        s[incramentCell()].ToString().Replace(",", "\n"), //replaces commas in the item cell with a new row insert

                        s[incramentCell()], s[incramentCell()], s[incramentCell()]);
                }
                cell = -1;
            }
            else
            {
                receiptDataGrid.Rows.Add("Error","Receipt","Not","Found");
            }
            
        }
        private int incramentCell()
        {
            cell += 1;
            return cell;

        }

        private void receiptDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
