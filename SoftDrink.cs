using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class SoftDrink : Product
    {
        public const string nameOfSoftDrink = "Soft drink";
        public const double priceOfSoftDrink = 1.6;

        public SoftDrink() : base(nameOfSoftDrink, priceOfSoftDrink)
        {
        }
    }
}
