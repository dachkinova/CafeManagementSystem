using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    public class CafeLatte : Product
    {
        protected const string nameOfCafe = "Cafe Latte";
        protected const double priceOfCafe = 2.5;
        protected const int quantityProduct = 1;

        public CafeLatte() : base(nameOfCafe, priceOfCafe, quantityProduct)
        {
        }
    }
}
