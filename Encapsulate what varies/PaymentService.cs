using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public class PaymentService
    {
        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            if (paymentMethod == "Bkash")
            {
                Console.WriteLine($"Processing Bkash payment of {amount}");
            }
            else if (paymentMethod == "Nagad")
            {
                Console.WriteLine($"Processing Nagad payment of {amount}");
            }
        }
    }
}
