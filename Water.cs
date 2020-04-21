using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class Water : Product
    {
        public const string nameOfWater = "Water";
        public const double priceOfWater = 1.1;

        public Water() : base(nameOfWater, priceOfWater)
        {
        }
    }
}
