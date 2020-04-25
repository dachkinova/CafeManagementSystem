using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class ByCash : PaymentMethod
    {
        private string totalBill;

        public ByCash(string totalBill)
        {
            this.totalBill = totalBill;
        }

        public override void ShowMessage()
        {
            CashPayment byCash = new CashPayment(totalBill);
            byCash.ShowDialog();
        }
    }
}
