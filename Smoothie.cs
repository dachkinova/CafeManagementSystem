using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    class Smoothie : Product 
    {
        protected const string nameOfSmoothie = "Smoothie";
        protected const double priceOfSmoothie = 4.5;
        protected const int quantityProduct = 1;
        public Smoothie() : base(nameOfSmoothie, priceOfSmoothie, quantityProduct)
        {
        }
    }
}
