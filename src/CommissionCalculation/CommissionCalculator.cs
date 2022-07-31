using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
    public const decimal CommissionPerCarSold = 250;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }

    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue) 
    {
        int allComissionForCarr = (amountCarsSold * 250);
        decimal allComissionForSales = (totalSalesValue * ( 3 / 100));

        var salaryComplet = allComissionForCarr + allComissionForSales + fixedSalary;

        this.FixedSalary = fixedSalary;
        this.AmountCarsSold = allComissionForCarr;
        this.TotalSalesValue = allComissionForSales;

        this.FinalSalary = salaryComplet;
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
        throw new NotImplementedException();
    }
}
