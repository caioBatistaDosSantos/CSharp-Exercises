using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
    public const decimal CommissionPerCarSold = 250;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public int AllComissionForCarr { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal AllComissionForSales { get; set; }
    public decimal FinalSalary { get; set; }

    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue) 
    {
        int allComissionForCarr = amountCarsSold * 250;
        decimal allComissionForSales = totalSalesValue * 3 / 100;

        var salaryComplet = allComissionForCarr + allComissionForSales + fixedSalary;

        FixedSalary = fixedSalary;
        AmountCarsSold = amountCarsSold;
        AllComissionForCarr = allComissionForCarr;
        TotalSalesValue = totalSalesValue;
        AllComissionForSales = allComissionForSales;

        FinalSalary = salaryComplet;
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
        Console.WriteLine("O colaborador " + contributorName + " neste mês de " + month + " obteve o salário final de R$" + FinalSalary.ToString("0.00") + " referente à: , ");
        Console.WriteLine("SALÁRIO FIXO: R$" + FixedSalary.ToString("0.00") + ", ");
        Console.WriteLine("TOTAL DE CARROS VENDIDOS: " + AmountCarsSold + ", ");
        Console.WriteLine("VALOR TOTAL DE VENDAS NO MÊS: R$" + TotalSalesValue.ToString("0.00") + ", ");
        Console.WriteLine("COMISSÃO POR CARROS VENDIDOS: R$" + AllComissionForCarr.ToString("0.00") + ", ");
        Console.WriteLine("COMISSÃO DE 3% DO TOTAL DE VENDAS: R$" + AllComissionForSales.ToString("0.00") + ", ");
    }
}
