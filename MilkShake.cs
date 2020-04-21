using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class MilkShake : Product
    {
        public const string nameOfMilkShake = "Milkshake";
        public const double priceOfMilkShake = 3.7;
        public MilkShake() : base(nameOfMilkShake, priceOfMilkShake)
        {
        }
    }
}
