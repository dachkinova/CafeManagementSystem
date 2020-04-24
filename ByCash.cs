using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class ByCash : PaymentMethod
    {
        public override void ShowMessage()
        {
            CashPayment byCash = new CashPayment();
            byCash.ShowDialog();
        }
    }
}
