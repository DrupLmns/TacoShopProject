using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace TacoShop
{
    class connectionObject
    {
        String ConnectionString = "Data Source = desktop-7r935i1;"
            + "Initial Catalog=TacoShop;"
            + "User id=user;"
            + "Password=abc123;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader rd;
        string s;
        
        public String returnFoodItem(string query) //Insert the food procedure in query to return that food
        {
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure

            s = "";
            while (rd.Read())//loops through all returned rows
            {
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    s += rd[i].ToString(); //loops through all returned cells and adds them to a string
                }
            }
            con.Close();

            return s;
        }
        public ArrayList lookupReceipt(String id) //Insert the receipt id to return that specific receipt
        {
            ArrayList s = new ArrayList();

            con = new SqlConnection(ConnectionString);
            if (id == "")
            {
                cmd = new SqlCommand("getReceipts", con);
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else if (Regex.Matches(id, @"[a-zA-Z]").Count > 0)
            { //Checks if input contains letters
                cmd = new SqlCommand("lookupReceiptName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@receiptName", SqlDbType.NChar).Value = id;
            }
            else
            {
                cmd = new SqlCommand("lookupReceiptID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@receiptID", SqlDbType.Int).Value = Int32.Parse(id);
            }

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure

            
            while (rd.Read())//loops through all returned rows
            {
                for (int i = 0; i < rd.FieldCount; i++)//loops through all returned cells and adds them to a string
                {
                    s.Add(rd[i].ToString());
                }
            }
            con.Close();
            return s;
        }
    }
}
