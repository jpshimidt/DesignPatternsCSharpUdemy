using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paypal payment = new Paypal();
            //Payonner payment = new Payonner();

            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceived();

            Console.ReadLine();
        }
    }
}
