using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public abstract class Buyable
    {
        private double price;

        public Buyable(double price)
        {
            this.Price = price;
        }
        public virtual double Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }
    }
}
