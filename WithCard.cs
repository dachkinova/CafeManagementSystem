using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenagementSystem
{
    public class WithCard : PaymentMethod
    {
        private string totalBill;

        public WithCard(string totalBill)
        {
            this.totalBill = totalBill;
            
        }

        public override void ShowMessage()
        {
            ByCardPayment byCard = new ByCardPayment(totalBill);
            byCard.ShowDialog();
        }
    }
}
