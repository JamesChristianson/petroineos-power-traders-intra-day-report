using Petroineos.PowerTradersReporting.Services.Abstractions;
using System;

namespace Petroineos.PowerTradersReporting.Services.Utility
{
    public class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        public DateTimeOffset Now()
        {
            return DateTimeOffset.Now;
        }
    }
}
