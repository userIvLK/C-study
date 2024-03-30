namespace DIConsole
{
    public class SalaryCalculator
    {
        private readonly ISalary _salary;
        private readonly ITax _tax;
        public SalaryCalculator(ISalary salary, ITax tax)
        {
            _salary = salary;
            _tax = tax;
        }

        public SalaryValue CalcNetSalary()
        {
            SalaryValue sal = _salary.GrosSalary;
            return new SalaryValue(sal.Amount - (sal.Amount * _tax.Tax / 100), sal.Currency);
        }
    }
}
