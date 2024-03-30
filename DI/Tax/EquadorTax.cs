namespace DIConsole
{
    public class EquadorTax : ITax
    {
        private readonly int tax = 35;
        private readonly ILogger _logger;

        public EquadorTax(ILogger logger)
        {
            _logger = logger;
        }
        public int Tax
        {
            get
            {
                _logger.Log($"Equador tax is {tax}");
                return tax;
            }
        }
    }
}
