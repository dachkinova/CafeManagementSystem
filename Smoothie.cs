using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class Smoothie : Product 
    {
        public const string nameOfSmoothie = "Smoothie";
        public const double priceOfSmoothie = 4.5;
        public Smoothie() : base(nameOfSmoothie, priceOfSmoothie)
        {
        }
    }
}
