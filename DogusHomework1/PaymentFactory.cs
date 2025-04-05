using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusHomework1
{
    public class PaymentFactory
    {
        public IPaymentMethod createObject(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(IPaymentMethod)).CreateInstance("DogusHomework1." + className);

            return (IPaymentMethod)newObject;
        }
    }
}
