using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Espresso : Product
    {
        protected const string nameOfEspresso = "Espresso";
        protected const double priceOfEspresso = 1.2;
        protected const int quantityProduct = 1;

        public Espresso() : base(nameOfEspresso, priceOfEspresso, quantityProduct)
        {
        }
    }
}
