using Exercicio_Interface.Entities;
using Exercicio_Interface.Interfaces;

namespace Exercicio_Interface.Services
{
    public class ContractService
    {
        public IOnlinePaymentService onlinePaymentService;

        public ContractService (IOnlinePaymentService onlinePaymentService)
        {
            onlinePaymentService = onlinePaymentService;
        }
        
        public void ProcessContract(Contract contract, int months)
        {

            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + onlinePaymentService.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
                                           
            }
            


        }



    }
}
