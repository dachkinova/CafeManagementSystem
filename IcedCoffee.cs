using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class IcedCoffee : Product
    {
        public const string nameOfIcedCoffee = "Iced coffee";
        public const double priceOfIcedCoffee = 2.2;
        public IcedCoffee() : base(nameOfIcedCoffee, priceOfIcedCoffee)
        {
        }
    }
}
