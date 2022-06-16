
using Microsoft.Extensions.DependencyInjection;
using Tipi.Tools.Payments.Interfaces;

namespace Tipi.Tools.Payments.Config
{
    /// <summary>
    /// Static class to provide access to service registrations,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi">See More</see>
    /// </summary>
    public static class ServiceRegistration
    {
        /// <summary>
        /// This method configures the <c>Culqi</c> class for Dependency Injection inside .Net Core, 
        /// <see href="https://docs.codingtipi.com/docs/toolkit/culqi">See More</see>.
        /// </summary>
        /// <remarks>
        /// Configure Dependency Injection.
        /// </remarks>
        /// <param name="services">App Service collection.</param>
        /// <param name="sKey">Your Secret Key provided by Culqi.</param>
        public static void ConfigureCulqiPaymentGateway(this IServiceCollection services, string sKey)
        {
            var authManager = new CulqiOptions(sKey);
            services.AddSingleton(authManager);
            services.AddTransient<ICulqi, Culqi>();
        }
    }
}
