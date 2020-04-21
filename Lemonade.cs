using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    class Lemonade : Product
    {
        public const string nameOfLemonade = "Lemonade";
        public const double priceOfLemonade = 2.1;

        public Lemonade() : base(nameOfLemonade, priceOfLemonade)
        {
        }
    }
}
