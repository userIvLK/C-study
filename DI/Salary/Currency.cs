using System.Collections.Generic;
using System.Linq;

namespace DIConsole
{
    public static class Currency
    {
        private static readonly Dictionary<CurrencyEnum, string> currencyDictionary = new()
        {
            { CurrencyEnum.USD, "USD" },
            { CurrencyEnum.PLN, "PLN" }
        };

        public static string GetName(CurrencyEnum currency)
        {
            return currencyDictionary.FirstOrDefault(c => c.Key == currency).Value;
        }
    }
}
