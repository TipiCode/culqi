namespace Tipi.Tools.Payments.Config
{
    public class CulqiOptions
    {
        /// <summary>
        /// Constructor to initialize the <c>CulqiOptions</c> object.
        /// </summary>
        /// <remarks>
        /// Takes as parameters, the Secret Key Culqi.
        /// </remarks>
        /// <param name="sKey">Your Secret Key provided by Culqi.</param>
        public CulqiOptions(string sKey)
        {
            SecretKey = sKey;
        }

        /// <summary>
        /// Your Secret Key provided by Culqi.
        /// </summary>
        public string SecretKey { get; }
    }
}
