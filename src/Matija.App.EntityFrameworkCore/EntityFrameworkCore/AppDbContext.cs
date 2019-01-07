using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Matija.App.Authorization.Roles;
using Matija.App.Authorization.Users;
using Matija.App.MultiTenancy;

namespace Matija.App.EntityFrameworkCore
{
    public class AppDbContext : AbpZeroDbContext<Tenant, Role, User, AppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
