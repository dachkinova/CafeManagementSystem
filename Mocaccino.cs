using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Mocaccino : Product
    {
        public const string nameOfMocaccino = "Mocaccino";
        public const double priceOfMocaccino = 2.6;
        public const int quantityProduct = 1;

        public Mocaccino() : base(nameOfMocaccino, priceOfMocaccino, quantityProduct)
        {
        }
    }
}
