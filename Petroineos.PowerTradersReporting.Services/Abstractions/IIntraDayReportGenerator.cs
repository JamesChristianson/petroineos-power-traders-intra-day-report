namespace Petroineos.PowerTradersReporting.Services.Abstractions
{
    public interface IIntraDayReportGenerator
    {
        Task GenerateReportAsync();
    }
}