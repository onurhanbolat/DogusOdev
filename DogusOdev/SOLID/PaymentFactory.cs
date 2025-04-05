using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusOdev.SOLID
{
    public class PaymentFactory
    {
        public IPayment newCreateObject(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(IPayment)).CreateInstance
            ("DogusOdev.SOLID." + className);

            return (IPayment)newObject;
        }
    }
}
