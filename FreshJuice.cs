using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class FreshJuice : Product
    {
        protected const string nameOfFreshJuice = "Fresh juice";
        protected const double priceOfFreshJuice = 4.1;
        protected const int quantityProduct = 1;
        public FreshJuice() : base(nameOfFreshJuice, priceOfFreshJuice, quantityProduct)
        {
        }
    }
}
