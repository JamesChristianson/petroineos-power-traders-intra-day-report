using Petroineos.PowerTradersReporting.Domain;
using Services;

namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IPositionAggrigator
    {
        IEnumerable<AggregatedPosition> Aggregate(IEnumerable<PowerTrade> trades);
    }
}