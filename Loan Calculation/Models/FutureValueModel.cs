using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Monthly Investment is required.")]
        public decimal MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Yearly Interest Rate is required.")]
        public decimal YearlyInvestmentRate { get; set; }

        [Required(ErrorMessage = "Number of Years is required.")]
        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            decimal futureValue = 0;
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInvestmentRate / 12 / 100;

            for (int i = 0; i < months; i++)
            {
                futureValue += MonthlyInvestment;
                futureValue *= (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}
