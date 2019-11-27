using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SuperRocket.AspNetCoreVue.EntityFrameworkCore
{
    public static class AspNetCoreVueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspNetCoreVueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspNetCoreVueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
