using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Espresso : Product
    {
        const double price = 1.9;

        public Espresso(double price) : base(price)
        {
        }
    }
}
