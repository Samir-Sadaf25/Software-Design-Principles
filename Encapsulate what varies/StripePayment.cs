using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public class StripePayment : IPayementMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Stripe payment proccession logic {amount}");
        }
    }
}
