namespace DIConsole
{
    public struct SalaryValue
    {
        public SalaryValue(decimal amount, CurrencyEnum currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; }
        public CurrencyEnum Currency { get; }
    }
}
