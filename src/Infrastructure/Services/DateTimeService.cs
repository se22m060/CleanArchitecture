using se22m060_swe_ca.Application.Common.Interfaces;

namespace se22m060_swe_ca.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
