using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusOdev.SOLID
{
    public class PaymentManager
    {
        public IPayment iPay;

        //Constructor Injection

        public PaymentManager(IPayment iPay)
        {
            this.iPay = iPay;
        }

        public string PaymentSave(string amount)
        {
            return iPay.pay(amount);
        }
    }
}
