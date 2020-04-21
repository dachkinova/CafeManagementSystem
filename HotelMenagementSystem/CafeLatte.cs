using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class CafeLatte : HotBeverages
    {
        const double price = 2.4;

        public CafeLatte(double price) : base(price)
        {
        }
    }
}
