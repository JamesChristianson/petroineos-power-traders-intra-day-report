using Petroineos.PowerTradersReporting.Domain;

namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IIntraDayCsvReportWriter
    {
        void Write(IEnumerable<AggregatedPosition> positionAggregations, DateTimeOffset date);
    }
}