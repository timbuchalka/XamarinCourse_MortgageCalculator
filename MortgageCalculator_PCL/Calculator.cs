using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator_PCL
{
    public class Calculator
    {
        public static float CalculateMonthlyPayment(float dollarsMortgageAmount, float percentageInterestRate, int yearsMortgageTerm)
        {
            float monthlyPayment = 0.0f;

            float monthlyInterestRate = (percentageInterestRate / 100) / 12;
            float monthsMortgageTerm = yearsMortgageTerm * 12;

            monthlyPayment = (monthlyInterestRate * dollarsMortgageAmount * ((float)Math.Pow((1 + monthlyInterestRate), monthsMortgageTerm))) / (((float)Math.Pow((1 + monthlyInterestRate), monthsMortgageTerm)) - 1);

            return monthlyPayment;
        }
    }
}
