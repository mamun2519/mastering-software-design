class BkashPayment {
    public void Pay() => Console.WriteLine("Paying with Bkash");
}

class PaymentService {
    private BkashPayment _bkash = new BkashPayment();

    public void MakePayment() {
        _bkash.Pay();  // tightly coupled
    }
}
