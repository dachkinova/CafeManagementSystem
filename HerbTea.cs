using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    public class HerbTea : Product
    {
        protected const string nameOfHerbTea = "Herb tea";
        protected const double priceOfHerbTea = 0.9;
        protected const int quantityProduct = 1;

        public HerbTea() : base(nameOfHerbTea, priceOfHerbTea, quantityProduct)
        {
        }
    }
}
