using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusHomework1
{
    public class PaymentProcess
    {
        public IPaymentMethod iPaymentMethod;

        public PaymentProcess(IPaymentMethod iPaymentMethod)
        {
            this.iPaymentMethod = iPaymentMethod;
        }

        public string payment(string amount)
        {
            return iPaymentMethod.pay(amount);
        }
    }
}
