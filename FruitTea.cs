using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class FruitTea : Product
    {
        protected const string nameOfFruitTea = "Fruit tea";
        protected const double priceOfFruitTea = 0.8;
        protected const int quantityProduct = 1;

        public FruitTea() : base(nameOfFruitTea, priceOfFruitTea, quantityProduct)
        {
        }
    }
}
