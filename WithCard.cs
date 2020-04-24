using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class WithCard : PaymentMethod
    {
        public override void ShowMessage()
        {
            ByCardPayment byCard = new ByCardPayment();
            byCard.ShowDialog();
        }
    }
}
