using DIConsole;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var servs = new ServiceCollection()
            .AddSingleton<ILogger, Logger>()
            .AddSingleton<ISalary, EquadorSalary>()
            .AddSingleton<ITax, EquadorTax>()
            .AddSingleton<SalaryCalculator>();

        using var serviceProvider = servs.BuildServiceProvider();

        SalaryCalculator? SC = serviceProvider.GetService<SalaryCalculator>();

        decimal? salaryAmount;
        salaryAmount = SC?.CalcNetSalary().Amount;
        List<decimal?> salary = new();
        Console.WriteLine();
        for(int i = 0; i<3; ++i)
        {
            salary.Add(SC?.CalcNetSalary().Amount);
        }
        Console.WriteLine();
        for(int i = 0; i<3; ++i)
        {
            Console.WriteLine($"month {i + 1}");
            Console.WriteLine(salary[i]);
        }
    }
}
