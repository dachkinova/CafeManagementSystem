using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    class BGN : Currency
    {
        public override double ConvertPrice(double price)
        {
            return price * 1.75;
        }
    }
}
