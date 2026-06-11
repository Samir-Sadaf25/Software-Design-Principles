using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class CreditcardPayment : IPaymentMethod
    {
        public void pay(double amount)
        {
            Console.WriteLine($"payment {amount} successfully to the marchant using Credit card");
        }
    }


}
