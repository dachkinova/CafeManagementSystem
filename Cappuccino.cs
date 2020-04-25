using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Cappuccino : Product
    {
        public const string nameOfCappucino = "Cappucino";
        public const double priceOfCappuccino = 1.9;
        public const int quantityProduct = 1;

        public Cappuccino() : base(nameOfCappucino, priceOfCappuccino, quantityProduct)
        {
        }
    }
}
