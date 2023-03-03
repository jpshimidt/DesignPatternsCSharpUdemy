namespace Adapter
{
    class PayonnerAdapter : IPayPalPayment
    {
        private readonly Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();

        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();

        }

        public void PayPalReceived()
        {
            this.payonner.ReceivedPayment();

        }
    }
}
