using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Mocaccino : Product
    {
        protected const string nameOfMocaccino = "Mocaccino";
        protected const double priceOfMocaccino = 2.6;
        protected const int quantityProduct = 1;

        public Mocaccino() : base(nameOfMocaccino, priceOfMocaccino, quantityProduct)
        {
        }
    }
}
