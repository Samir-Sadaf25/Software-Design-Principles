using Factory_Pattern;

IPaymentMethod paymentMethod = PaymentFactory.Create(PaymentMethod.GPay);
paymentMethod.pay(100);