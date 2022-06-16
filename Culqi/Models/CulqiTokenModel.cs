namespace Tipi.Tools.Payments.Models
{
    /// <summary>
    /// Class representing the Culqi token object, 
    /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi/classes#culqi-token-model">See More</see>
    /// </summary>
    public class CulqiTokenModel
    {
        /// <summary>
        /// Your Payment Method Id.
        /// </summary>
        public string Id { get; } = default!;

        /// <summary>
        /// Customer email
        /// </summary>
        public string Email { get; } = default!;

        /// <summary>
        /// Total checkout amount
        /// </summary>
        public int Amount { get; }

        /// <summary>
        /// Checkout currency code
        /// </summary>
        public string CurrencyCode { get; } = default!;

        /// <summary>
        /// Constructor to initialize the <c>Card</c> object.
        /// </summary>
        /// <param name="id">Your Payment Method Id.</param>
        /// <param name="email">Customer email.</param>
        /// <param name="amount">Total checkout amount.</param>
        /// <param name="currencyCode">Checkout currency code.</param>
        public CulqiTokenModel(string id, string email, int amount, string? currencyCode)
        {
            Id = id;
            Email = email;
            Amount = amount;
            CurrencyCode = currencyCode ?? "PEN";
        }
    }
}
