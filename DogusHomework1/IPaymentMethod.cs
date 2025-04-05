using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusHomework1
{
    public interface IPaymentMethod
    {
        string pay(string amount);
    }
}
