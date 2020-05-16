using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMenagementSystem
{
    public class PaymentMethod : CheckOutForm
    {
        public virtual void ShowMessage()
        {
            MessageBox.Show("Please pick a payment method and then click OK to pay.");
        }
    }

    

}
