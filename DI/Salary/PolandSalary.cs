using System;

namespace DIConsole
{
    public class PolandSalary : ISalary
    {
        private readonly ILogger _logger;
        private readonly SalaryValue salary = new(new Random().Next(2800, 3200), CurrencyEnum.PLN);

        public PolandSalary(ILogger logger)
        {
            _logger = logger;
        }

        public SalaryValue GrosSalary
        {
            get
            {
                _logger.Log($"Poland salary is {salary.Amount} {Currency.GetName(salary.Currency)}");
                return salary;
            }
        }
    }
}
