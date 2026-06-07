using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public class PaymentCheckout
    {
        private readonly IPayementMethod _paymentMethod;

        public PaymentCheckout(IPayementMethod payementMethod)
        {
            _paymentMethod = payementMethod;
        }

        public void Checkout(decimal amount)
        {
            Console.WriteLine("Creating order");
            _paymentMethod.Pay(amount);
            Console.WriteLine("order completed");
        }

    }
}
