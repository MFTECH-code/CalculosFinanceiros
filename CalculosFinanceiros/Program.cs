var outstandingBalance = 120000.0;
var installmentNumber = 10;
var interestPercentage = 0.05;
var installmentValue = 0.0;
var amortizationValue = outstandingBalance / installmentNumber;

for (int i = 0; i <= installmentNumber; i++)
{
    if (i == 0)
        continue;

    var installmentInterestValue = outstandingBalance * interestPercentage;
    installmentValue = installmentInterestValue + amortizationValue;
    outstandingBalance -= amortizationValue;
    Console.WriteLine($"Parcela {i} - Valor: R${installmentValue.ToString("F2")}");
    Console.WriteLine($"Juros: R${installmentInterestValue.ToString("F2")}");
    Console.WriteLine("-----------------------------------------------------------");
}