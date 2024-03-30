namespace DIConsole
{
    public class PolandTax : ITax
    {
        private readonly int tax = 19;
        private readonly ILogger _logger;

        public PolandTax(ILogger logger)
        {
            _logger = logger;
        }
        public int Tax
        {
            get
            {
                _logger.Log($"Poland tax is {tax}");
                return tax;
            }
        }
    }
}
