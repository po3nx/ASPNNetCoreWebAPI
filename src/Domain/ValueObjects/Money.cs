
namespace Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        private Money() { } // Parameterless constructor for EF Core

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            if (obj is Money other)
            {
                return Amount == other.Amount && Currency == other.Currency;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency);
        }
    }
}
