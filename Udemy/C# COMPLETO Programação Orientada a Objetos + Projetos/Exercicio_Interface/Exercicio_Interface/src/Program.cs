using Exercicio_Interface.Entities;
using Exercicio_Interface.Services;
using System.Globalization;



Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int numberContract = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new Contract(numberContract, date, valueContract);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, months);



Console.WriteLine("Installments: ");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}
