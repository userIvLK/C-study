using DIConsole;

class Program
{
    static void Main(string[] args)
    {
        ILogger MyLog = new Logger();
        ISalary EqSalary = new EquadorSalary(MyLog);
        ITax EqTax = new EquadorTax(MyLog);
        SalaryCalculator SC = new(EqSalary, EqTax);
        Console.WriteLine(SC.CalcNetSalary().Amount);
    }
}