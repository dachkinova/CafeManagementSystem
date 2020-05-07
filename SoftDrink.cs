using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    class SoftDrink : Product
    {
        protected const string nameOfSoftDrink = "Soft drink";
        protected const double priceOfSoftDrink = 1.6;
        protected const int quantityProduct = 1;

        public SoftDrink() : base(nameOfSoftDrink, priceOfSoftDrink, quantityProduct)
        {
        }
    }
}
