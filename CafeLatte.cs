using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class CafeLatte : Product
    {
        public const string nameOfCafe = "Cafe Latte";
        public const double priceOfCafe = 2.5;

        public CafeLatte() : base(nameOfCafe, priceOfCafe)
        {
        }
    }
}
