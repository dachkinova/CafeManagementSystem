using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Espresso : Product
    {
        public const string nameOfEspresso = "Espresso";
        public const double priceOfEspresso = 1.2;
        public const int quantityProduct = 1;

        public Espresso() : base(nameOfEspresso, priceOfEspresso, quantityProduct)
        {
        }
    }
}
