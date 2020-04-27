using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class Lemonade : Product
    {
        protected const string nameOfLemonade = "Lemonade";
        protected const double priceOfLemonade = 2.1;
        protected const int quantityProduct = 1;

        public Lemonade() : base(nameOfLemonade, priceOfLemonade, quantityProduct)
        {
        }
    }
}
