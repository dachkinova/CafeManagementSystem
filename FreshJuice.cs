using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class FreshJuice : Product
    {
        public const string nameOfFreshJuice = "Fresh juice";
        public const double priceOfFreshJuice = 4.1;
        public const int quantityProduct = 1;
        public FreshJuice() : base(nameOfFreshJuice, priceOfFreshJuice, quantityProduct)
        {
        }
    }
}
