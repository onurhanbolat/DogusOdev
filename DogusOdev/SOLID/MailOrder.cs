using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusOdev.SOLID
{
    public class MailOrder : IPayment
    {
        public string pay(string amount)
        {
            return amount + "$ Payment Made with Mail Order";
        }
    }
}
