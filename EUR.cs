using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    class EUR : Currency
    {
        public override double ConvertPrice(double price)
        {
            return price * 0.88;
        }
    }
}
