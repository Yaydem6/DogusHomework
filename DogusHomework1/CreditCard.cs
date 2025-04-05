using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusHomework1
{
    public class CreditCard : IPaymentMethod
    {
        public string pay(string amount)
        {
            return amount + "$ payment made with credit card.";
        }
    }
}
