using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Mocaccino : HotBeverages
    {
        const double price = 2.4;

        public Mocaccino(double price) : base(price)
        {
        }
    }
}
