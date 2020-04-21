using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class Cappuccino : Product
    {

        public const double PRICE_OF_CAPPUCINO = 1.7;

        public Cappuccino() : base(PRICE_OF_CAPPUCINO)
        {
        }
    }
}
