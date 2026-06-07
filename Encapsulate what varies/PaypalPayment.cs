using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public class PaypalPayment : IPayementMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"paypal payment proccession logic {amount}");
        }
    }
}
