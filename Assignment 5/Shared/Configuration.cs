using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Assignment_5.Shared
{
    internal class Configuration
    {
        internal static Action<SqlServerDbContextOptionsBuilder>? GetConnectionString(string v)
        {
            throw new NotImplementedException();
        }
    }
}