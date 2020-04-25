using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class FruitTea : Product
    {
        public const string nameOfFruitTea = "Fruit tea";
        public const double priceOfFruitTea = 0.8;
        public const int quantityProduct = 1;

        public FruitTea() : base(nameOfFruitTea, priceOfFruitTea, quantityProduct)
        {
        }
    }
}
