using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;
using TacoShop;
using System.Security.Cryptography;

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
        
        public Item returnFoodItem(string query) //Insert the food procedure in query to return that food
        {
            int ItemID = 0;
            String ItemName = "";
            Double ItemPrice = 0;

            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure

            s = "";
            while (rd.Read())//loops through all returned rows
            {
                String ItemIDtemp = rd[0].ToString();
                ItemID = Int32.Parse(ItemIDtemp);

                ItemName = rd[1].ToString();

                String ItemPricetemp = rd[2].ToString();
                ItemPrice = Double.Parse(ItemPricetemp);
            }
            con.Close();

            Item i = new Item(ItemID, ItemName, ItemPrice);
            return i;
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
        public void CreateUser(
            String name,
            String username,
            String password,
            int admin)
        {
            Random rnd = new Random();
            //hashes the password
            String hash = hashify(password);

            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand("CreateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = rnd.Next();
            cmd.Parameters.Add("@Employee_Name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = hash;
            cmd.Parameters.Add("IsAdmin", SqlDbType.Int).Value = admin;

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure
            con.Close();
        }

        public User GetUser(String username, String password)
        {
            User u;

            String name = "ERROR";
            int admin = 0;

            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand("EmployeeLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NChar).Value = username;

            String hash = hashify(password);

            Debug.WriteLine(hash);

            cmd.Parameters.Add("@password", SqlDbType.NChar).Value = hash;

            con.Open();//Open connection to database
            rd = cmd.ExecuteReader(); //executes the procedure

            while (rd.Read())//loops through all returned rows
            {


                for (int i = 0; i < rd.FieldCount; i++)//loops through all returned cells and adds them to a string
                {


                    if (i == 1)
                    {
                        name = rd[1].ToString();
                    }
                    if (i == 4)
                    {
                        if(rd[4].ToString() == "1")
                        {
                            admin = 1;
                        }
                    }
                }
            }
            u = new User(name, admin);

            con.Close();

            return u;
        }

        private string hashify(String h)
        {
            //Hashing the password
            SHA256 s = SHA256.Create();
            //converts passwod into bytes (needed for the hash algorithm)
            byte[] bytes = s.ComputeHash(Encoding.UTF8.GetBytes(h));

            //Hashing the bytes and combining them
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            string hash = builder.ToString();
            return hash;
        }
    }
}
