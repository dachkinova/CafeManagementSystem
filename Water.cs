using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    class Water : Product
    {
        protected const string nameOfWater = "Water    ";
        protected const double priceOfWater = 1.1;
        protected const int quantityProduct = 1;

        public Water() : base(nameOfWater, priceOfWater, quantityProduct)
        {
        }
    }
}
