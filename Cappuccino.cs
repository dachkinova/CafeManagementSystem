using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    public class Cappuccino : Product
    {
        protected const string nameOfCappucino = "Cappucino";
        protected const double priceOfCappuccino = 1.9;
        protected const int quantityProduct = 1;

        public Cappuccino() : base(nameOfCappucino, priceOfCappuccino, quantityProduct)
        {
        }
    }
}
