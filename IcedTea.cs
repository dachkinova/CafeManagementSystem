using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    [Serializable]
    class IcedTea : Product
    {
        protected const string nameOfIcedTea = "Iced tea";
        protected const double priceOfIcedTea = 1.5;
        protected const int quantityProduct = 1;
        public IcedTea() : base(nameOfIcedTea, priceOfIcedTea, quantityProduct)
        {
        }
    }
}
