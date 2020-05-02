using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public abstract class Product 
    {
        public string name;
        public double price;
        public double quantity;
        public string currentItem;
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public Product()
        {
            
        }
        public string Name { get; set; }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }


        public double GetTotalPrice 
        { 
            get { return price; } 
        }

       
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0} {1,25:f2}", 
                this.GetType().Name, this.Price));


            return builder.ToString();
        }
    }
}
