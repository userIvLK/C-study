using DIConsole;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var servs = new ServiceCollection()
            .AddSingleton<ILogger, Logger>()
            .AddTransient<ISalary, PolandSalary>()
            .AddSingleton<ITax, PolandTax>()
            .AddTransient<SalaryCalculator>();

        using var serviceProvider = servs.BuildServiceProvider();

        List<decimal?> salary = new();
        Console.WriteLine();
        for(int i = 0; i<3; ++i)
        {
            salary.Add(serviceProvider.GetService<SalaryCalculator>()?.CalcNetSalary().Amount);
        }
        Console.WriteLine();
        for(int i = 0; i<3; ++i)
        {
            Console.WriteLine($"month {i + 1}");
            Console.WriteLine(salary[i]);
        }

    }
}