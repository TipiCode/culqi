
using Tipi.Tools.Payments.Models;

namespace Tipi.Tools.Payments.Interfaces
{
    /// <summary>
    /// Interface <c>ICulqi</c> serves as an interace to implement the Class <c>Culqi</c>,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi">See More</see>
    /// </summary>
    /// <remarks>
    /// Exposes methods to interact with the payment gateway Culqi.
    /// </remarks>
    public interface ICulqi
    {
        /// <summary>
        /// This method captures a new single paymente.
        /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi/methods#create-single-payment-async">See More</see>.
        /// </summary>
        /// <remarks>
        /// Captures a new single paymente.
        /// </remarks>
        /// <param name="request">ACulqiModel request</param>
        /// <returns>
        /// Returns a <c>String</c> containing the payment result.
        /// </returns>
        Task<dynamic> CreateSinglePaymentAsync(CulqiTokenModel request);
    }
}
