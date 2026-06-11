using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class PaymentFactory
    {
        public static IPaymentMethod Create(PaymentMethod paymentMethod)
        {
             switch(paymentMethod)
            {
                case PaymentMethod.Paypal: return new PaypalPayment();

                case PaymentMethod.Creditcard: return new CreditcardPayment();

                case PaymentMethod.GPay: return new GooglePayment();
                default: throw new NotSupportedException($"currently this {paymentMethod} is not supported");
            }
        }
    }
}
