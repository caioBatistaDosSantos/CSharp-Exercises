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
        int allComissionForCarr = (amountCarsSold * 250);
        decimal allComissionForSales = (totalSalesValue * ( 3 / 100));

        var salaryComplet = allComissionForCarr + allComissionForSales + fixedSalary;

        this.FixedSalary = fixedSalary;
        this.AmountCarsSold = amountCarsSold;
        this.AllComissionForCarr = allComissionForCarr;
        this.TotalSalesValue = totalSalesValue;
        this.AllComissionForSales = allComissionForSales;

        this.FinalSalary = salaryComplet;
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
        Console.WriteLine(
            "O colaborador " + contributorName + " neste mês de " + month + " obteve o salário final de R$" + this.FinalSalary + " referente à: " + "\r\n" + "SALÁRIO FIXO: R$" + this.FixedSalary + "\r\n" + "TOTAL DE CARROS VENDIDOS: " + this.AmountCarsSold + "\r\n" + "VALOR TOTAL DE VENDAS NO MÊS: R$" + this.TotalSalesValue + "\r\n" + "COMISSÃO POR CARROS VENDIDOS: R$" + this.AllComissionForCarr + "\r\n" + "COMISSÃO DE 3% DO TOTAL DE VENDAS: R$" + this.AllComissionForSales
        );
    }
}
