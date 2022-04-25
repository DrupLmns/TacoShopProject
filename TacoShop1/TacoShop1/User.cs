using System;
using System.Collections.Generic;
using System.Text;

namespace TacoShop
{
    public class User
    {
        String name = "";
        int admin = 0;//if they have admin privlidges 0 = no 1 = yes

        public User(String n, int a)
        {
            this.name = n;
            this.admin = a;
        }
        public string getName()
        {
            return this.name;
        }

        public int getAdmin()
        {
            return this.admin;
        }
    }
}
