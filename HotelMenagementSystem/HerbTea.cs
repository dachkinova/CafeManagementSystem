using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{

    public class HerbTea : HotBeverages
    {
        const double price = 0.9;

        public HerbTea(double price) : base(price)
        {
        }
    }
}
