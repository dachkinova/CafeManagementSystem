using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Product 
    {
        public string name;
        public double price;
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
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
        
        public double GetTotalPrice 
        { 
            get { return price; } 
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0} {1,25}", this.GetType().Name, this.Price));


            return builder.ToString();
        }
    }
}
