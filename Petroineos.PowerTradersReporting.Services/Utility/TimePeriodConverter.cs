using Petroineos.PowerTradersReporting.Services.Abstractions;

namespace Petroineos.PowerTradersReporting.Services.Utility
{
    public class TimePeriodConverter : ITimePeriodConverter
    {
        public string ToTimePeriod(int period)
        {
            return DateTime.Today.AddHours(period - 2).ToString("HH:mm");
        }
    }
}
