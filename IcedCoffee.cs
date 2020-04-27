using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class IcedCoffee : Product
    {
        protected const string nameOfIcedCoffee = "Iced coffee";
        protected const double priceOfIcedCoffee = 2.2;
        protected const int quantityProduct = 1;
        public IcedCoffee() : base(nameOfIcedCoffee, priceOfIcedCoffee, quantityProduct)
        {
        }
    }
}
