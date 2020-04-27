using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class GreenTea : Product
    {
        protected const string nameOfGreenTea = "Green tea";
        protected const double priceOfGreenTea = 1.2;
        protected const int quantityProduct = 1;

        public GreenTea() : base(nameOfGreenTea, priceOfGreenTea, quantityProduct)
        {
        }
    }
}
