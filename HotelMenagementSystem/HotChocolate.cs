using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class HotChocolate : HotBeverages
    {
        const double price = 2.0;

        public HotChocolate(double price) : base(price)
        {
        }
    }
}
