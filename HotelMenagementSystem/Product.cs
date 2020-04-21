using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Product : Buyable
    {
        public Product(double price) : base(price)
        {
        }

        public override double Price
        {
            get { return base.Price; }
        }

        public double GetTotalPrice
        {
            get { return base.Price; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0,-20} {1,25}", this.GetType().Name, this.Price));


            return builder.ToString();
        }
    }
}
