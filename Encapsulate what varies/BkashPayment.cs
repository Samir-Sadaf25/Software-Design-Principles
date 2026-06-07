using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public class BkashPayment : IPayementMethod
    {
       
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Bkash payment proccession logic {amount}");
        }
    }
}
