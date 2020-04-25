using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class GreenTea : Product
    {
        public const string nameOfGreenTea = "Green tea";
        public const double priceOfGreenTea = 0.8;
        public const int quantityProduct = 1;

        public GreenTea() : base(nameOfGreenTea, priceOfGreenTea, quantityProduct)
        {
        }
    }
}
