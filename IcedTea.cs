using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class IcedTea : Product
    {
        public const string nameOfIcedTea = "Iced tea";
        public const double priceOfIcedTea = 1.5;
        public IcedTea() : base(nameOfIcedTea, priceOfIcedTea)
        {
        }
    }
}
