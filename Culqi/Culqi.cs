using Newtonsoft.Json;
using Tipi.Tools.Payments.Config;
using Tipi.Tools.Payments.Interfaces;
using Tipi.Tools.Http;
using Tipi.Tools.Payments.Models;

namespace Tipi.Tools.Payments
{
    /// <summary>
    /// Class <c>Culqi</c> serves as an interace to interact with the Payment Gateway Culqi,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi">See More</see>
    /// </summary>
    /// <remarks>
    /// Exposes methods to interact with the payment gateway Culqi.
    /// </remarks>
    public class Culqi : ICulqi
    {
        private readonly string _sKey;
        public Culqi(CulqiOptions options)
        {
            _sKey = options.SecretKey;
        }

        public async Task<dynamic> CreateSinglePaymentAsync(CulqiTokenModel culqiRequest)
        {
            try
            {
                string key = _sKey;
                var testObject = new { amount = culqiRequest.Amount, currency_code = culqiRequest.CurrencyCode, email = culqiRequest.Email, source_id = culqiRequest.Id };
                var request = new HttpRequestHandler(key);
                var response = await request.ExecuteAsync("POST", Constants.ApiEndpoint, JsonConvert.SerializeObject(testObject));

                return response;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error ocurred processing the payment", ex);
            }
        }
    }
}
