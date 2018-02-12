using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpTemplate.Authorization.Roles;
using AbpTemplate.Authorization.Users;
using AbpTemplate.MultiTenancy;

namespace AbpTemplate.EntityFrameworkCore
{
    public class AbpTemplateDbContext : AbpZeroDbContext<Tenant, Role, User, AbpTemplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpTemplateDbContext(DbContextOptions<AbpTemplateDbContext> options)
            : base(options)
        {
        }
    }
}
