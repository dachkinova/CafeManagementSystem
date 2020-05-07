using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    class MilkShake : Product
    {
        protected const string nameOfMilkShake = "Milkshake";
        protected const double priceOfMilkShake = 3.7;
        protected const int quantityProduct = 1;
        public MilkShake() : base(nameOfMilkShake, priceOfMilkShake, quantityProduct)
        {
        }
    }
}
