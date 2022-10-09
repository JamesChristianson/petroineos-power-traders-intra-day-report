using System;

namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IDateTimeOffsetProvider
    {
        DateTimeOffset Now();
    }
}