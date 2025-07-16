interface IPaymentMethod {
    void Pay();
}

class BkashPayment : IPaymentMethod {
    public void Pay() => Console.WriteLine("Bkash Payment");
}

class NagadPayment : IPaymentMethod {
    public void Pay() => Console.WriteLine("Nagad Payment");
}

class PaymentService {
    private IPaymentMethod _payment;

    public PaymentService(IPaymentMethod payment) {
        _payment = payment;
    }

    public void MakePayment() {
        _payment.Pay();  // depends on abstraction
    }
}
