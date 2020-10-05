using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Order_Management
{
    class Item
    {
        private int id;
        private string name;
        private double price;
        private int qty;

        public Item(int id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

    }
}
