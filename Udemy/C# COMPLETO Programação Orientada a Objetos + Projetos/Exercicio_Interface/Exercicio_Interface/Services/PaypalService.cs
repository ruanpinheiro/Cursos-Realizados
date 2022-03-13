
using Exercicio_Interface.Interfaces;

namespace Exercicio_Interface.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private double simpleInterest = 0.01;
        private double paymentFee = 0.02;

        public double Interest(double amount, int months)
        {
            return amount * simpleInterest * months;
                                  

        }
        public double PaymentFee(double amount)
        {
            return amount * paymentFee;                  
        }
       
        


    }
}
