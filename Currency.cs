using HotelMenagementSystem;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CafeManagementSystem
{
    public abstract class Currency
    {
        public double price;

        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public virtual double ConvertPrice(double price)
        {
            return price;
        }
    }
}
