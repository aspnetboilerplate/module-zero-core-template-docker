using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpTemplate.EntityFrameworkCore
{
    public static class AbpTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlite(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlite(connection);
        }
    }
}
