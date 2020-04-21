using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{

    public class HerbTea : Product
    {
        public const string nameOfHerbTea = "Herb tea";
        public const double priceOfHerbTea = 0.9;

        public HerbTea() : base(nameOfHerbTea, priceOfHerbTea)
        {
        }
    }
}
