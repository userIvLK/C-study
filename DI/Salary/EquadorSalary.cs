using System;

namespace DIConsole
{
    public class EquadorSalary : ISalary
    {
        private readonly ILogger _logger;
        private readonly SalaryValue salary = new(new Random().Next(220, 270), CurrencyEnum.USD);

        public EquadorSalary(ILogger logger)
        {
            _logger = logger;
        }

        public SalaryValue GrosSalary
        {
            get
            {
                _logger.Log($"Equador salary is {salary.Amount} {Currency.GetName(salary.Currency)}");
                return salary;
            }
        }
    }
}
