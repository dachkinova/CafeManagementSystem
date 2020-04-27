using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class HotChocolate : Product
    {
        protected const string nameOfHotChocolate = "Hot chocolate";
        protected const double priceOfHotChocolate = 2.9;
        protected const int quantityProduct = 1;

        public HotChocolate() : base(nameOfHotChocolate, priceOfHotChocolate, quantityProduct)
        {
        }
    }
}
       
    

