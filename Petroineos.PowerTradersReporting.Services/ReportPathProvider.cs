using Microsoft.Extensions.Options;
using Petroineos.PowerTradersReporting.Services.Abstractions;

namespace Petroineos.PowerTradersReporting.Services
{
    public class ReportPathProvider : IReportPathProvider
    {
        private readonly string _filePath;

        public ReportPathProvider(IOptions<ReportOptions> reportOptions)
        {
            if (string.IsNullOrEmpty(reportOptions.Value.ReportsPath))
                throw new ArgumentException("Reports file path is not specified");

            _filePath = reportOptions.Value.ReportsPath;
        }

        public string GetPath(DateTimeOffset date)
        {
            return Path.Combine(_filePath, $"PowerPosition_{date:yyyyMMdd_HHmm}.csv");
        }
    }
}
