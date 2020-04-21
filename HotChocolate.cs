using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class HotChocolate : Product
    {
        public const string nameOfHotChocolate = "Hot chocolate";
        public const double priceOfHotChocolate = 2.9;

        public HotChocolate() : base(nameOfHotChocolate, priceOfHotChocolate)
        {
        }
    }
}
       
    

