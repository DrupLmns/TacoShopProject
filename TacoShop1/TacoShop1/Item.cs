using System;
using System.Collections.Generic;
using System.Text;

namespace TacoShop
{
    class Item
    {
        public int foodID;
        public String name;
        public Double price;
        public int ammount = 1;

        public Item(int foodID, String name, Double price)
        {
            this.foodID = foodID;
            this.name = name;
            this.price = price;
        }
        public void addAmmount(double price)
        {
            this.ammount = this.ammount + 1;
            this.price = (this.price + price);
        }
    }

}
