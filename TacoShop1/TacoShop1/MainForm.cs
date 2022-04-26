using System;
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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace TacoShop1
{
    public partial class MainForm : Form
    {
        User user;
        connectionObject con = new connectionObject();

        Form receipt = new ReceiptForm();
        
        string Item;
        Double BaseTotal;
        Double Tax;
        readonly Double TaxRate = 0.09;
        Double Total;
        List<Item> receiptList = new List<Item>();
        
        public void LoadUser(User u)
        {
            user = u;

            if (user.getAdmin() == 1)
            {
                label2.Text = (user.getName() + "you are a Admin!");
            }
            else
            {
                label2.Text = (user.getName() + "!");
            }
        }

        public MainForm()
        {
            
            InitializeComponent();
            taxBox.Text = ("TAX (" + (TaxRate * 100) + "%):");

            //con.CreateUser("Maggie","HomerSimpson420","McDonalds",1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TacoButton_Click(object sender, EventArgs e)
        {
            Item i = con.returnFoodItem("getTaco");
            checkStackup(i);
            updateReceiptList();
            addMoney(i.price);
        }
        private void BurritoButton_Click(object sender, EventArgs e)
        {
            Item i = con.returnFoodItem("getBurrito");
            checkStackup(i);
            updateReceiptList();
            addMoney(i.price);
        }
        private void WaterButton_Click(object sender, EventArgs e)
        {
            Item i = con.returnFoodItem("getWater");
            checkStackup(i);
            updateReceiptList();
            addMoney(i.price);
        }
        private void SodaButton_Click(object sender, EventArgs e)
        {
            Item i = con.returnFoodItem("getSoda");
            checkStackup(i);
            updateReceiptList();
            addMoney(i.price);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReceiptBox.Items.Clear();
            receiptList.Clear();
            Tax = 0;
            Total = 0;
            BaseTotal = 0;
            taxLabel.Text = "0.00";
            totalLabel.Text = "0.00";
        }

        private void create_receipt_button_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = desktop-7r935i1;"
            + "Initial Catalog=TacoShop;"
            + "User id=user;"
            + "Password=abc123;";
            
            SqlConnection con;
            double placeHolderTip = 0.15;
            var list = new List<string>();
            Random IDgenerator = new Random();              
            string nameText = nametextBox.Text;
            int IDnumber;
            IDnumber = IDgenerator.Next(30, 50); //You can change these parameters for the number limitations to whatever. This was just to ensure no duplicates for the trial run.
            Regex trimmer = new Regex(@"\s\s+"); //This trims out the white space on inserts, letting you put more. 
//The way this is now, you can store up to three values in one cell.
            string allItems = string.Join(",", ReceiptBox.Items.OfType<object>());
            allItems = allItems.TrimEnd();
            allItems = trimmer.Replace(allItems, " ");
            
            
            if (ReceiptBox.Items.Count != 0)
            {
                
                con = new SqlConnection(ConnectionString);
                 
                //Inserting parameter strings
                using (SqlCommand insert = new SqlCommand("CreateReceipt", con))
                {
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = IDnumber;
                    insert.Parameters.AddWithValue("@Name", SqlDbType.NChar).Value = nameText;
                    insert.Parameters.AddWithValue("@choices", SqlDbType.VarChar).Value = allItems;                  
                    insert.Parameters.AddWithValue("@tax", SqlDbType.Money).Value = Tax;
                    insert.Parameters.AddWithValue("@tip", SqlDbType.Money).Value = placeHolderTip;
                    insert.Parameters.AddWithValue("@finaltotal", SqlDbType.Money).Value = Total;
                    con.Open();                      
                    insert.ExecuteReader();
                    con.Close();                                  
                }
                MessageBox.Show("Records inserted succesfully.");
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }
        

        
        
        private void view_receipts_button_Click(object sender, EventArgs e)
        {
            receipt.Show(this);
        }

        private void addMoney(Double m)
        {


            BaseTotal = BaseTotal + m;

            Tax = (BaseTotal * TaxRate); // 10 percent of base total
            Total = BaseTotal + Tax; // adds base total and tax

            taxLabel.Text = Tax.ToString("C"); // "C" converts the double into money format
            totalLabel.Text = Total.ToString("C");
        }
        private void checkStackup(Item n)
        {
            int add = 0;
            if (receiptList.Count == 0) // if the list is initially 0
            {
                receiptList.Add(n);
            }
            else //checks to see if the item is already in the list, if so adds 1 to the ammount
            {
                for (int i = 0; i < receiptList.Count; i++)
                {
                    if (n.foodID == receiptList[i].foodID)
                    {
                        receiptList[i].addAmmount(n.price);
                        add = 0;
                        break;
                    }
                    else if(n.foodID != receiptList[i].foodID)
                    {
                        add = 1;
                    }
                }
                if (add == 1)
                {
                    receiptList.Add(n);
                    add = 0;
                }
            }
        }
        private void updateReceiptList()
        {
            ReceiptBox.Items.Clear();

            for(int i = 0; i < receiptList.Count; i++)
            {
                ReceiptBox.Items.Add(receiptList[i].name + " x" + receiptList[i].ammount + " $" + receiptList[i].price);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
