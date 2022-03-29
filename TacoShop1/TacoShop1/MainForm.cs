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

namespace TacoShop1
{
    public partial class MainForm : Form
    {
        String ConnectionString = "Data Source = desktop-7r935i1;"
            + "Initial Catalog=TacoShop1;"
            + "User id=user;"
            + "Password=abc123;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader rd;
        public MainForm()
        {
            
            InitializeComponent();
            con = new SqlConnection(ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

          int InsertProduct() //This is the method for adding textbox values into the database
        {
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand MyCommand = new SqlCommand("INSERT INTO TacoShop1.dbo.Receipt (choices) Values (@Column1)", myConnection);
                MyCommand.Parameters.AddWithValue("@Column1", ReceiptBox.Text);
                myConnection.Open();
                return MyCommand.ExecuteNonQuery();

            }
        }

        private void TacoButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("getTaco", con);//first is the procedure, second is the connection to the sqlserver
            cmd.CommandType = CommandType.StoredProcedure; 
            

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure
            while (rd.Read())//loops through all returned values,
            {
                ReceiptBox.Items.Add( (rd[0].ToString() + rd[1].ToString()) );
                InsertProduct(); //This is where I've been initializing the method
            }
            con.Close();
        }
        private void BurritoButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("getBurrito", con);//first is the procedure, second is the connection to the sqlserver
            cmd.CommandType = CommandType.StoredProcedure;


            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure
            while (rd.Read())//loops through all returned values,
            {
                ReceiptBox.Items.Add((rd[0].ToString() + rd[1].ToString()));
                InsertProduct();
            }
            con.Close();
        }
        private void WaterButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("getWater", con);//first is the procedure, second is the connection to the sqlserver
            cmd.CommandType = CommandType.StoredProcedure;


            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure
            while (rd.Read())//loops through all returned values,
            {
                ReceiptBox.Items.Add((rd[0].ToString() + rd[1].ToString()));
                InsertProduct();
            }
            con.Close();
        }
        private void SodaButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("getSoda", con);//first is the procedure, second is the connection to the sqlserver
            cmd.CommandType = CommandType.StoredProcedure;


            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure
            while (rd.Read())//loops through all returned values,
            {
                ReceiptBox.Items.Add((rd[0].ToString() + rd[1].ToString()));
                InsertProduct();
            }
            con.Close();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReceiptBox.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
