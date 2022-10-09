using Polly;

namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IPolicyProvider
    {
        AsyncPolicy GetRetryPolicy();
    }
}