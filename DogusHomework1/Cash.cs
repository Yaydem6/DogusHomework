using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusHomework1
{
    public class Cash : IPaymentMethod
    {
        public string pay(string amount)
        {
            return amount + "$ payment made with cash.";
        }
    }
    
}
