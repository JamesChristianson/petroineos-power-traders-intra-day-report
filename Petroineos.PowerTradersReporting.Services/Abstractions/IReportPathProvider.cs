using System;

namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IReportPathProvider
    {
        string GetPath(DateTimeOffset date);
    }
}