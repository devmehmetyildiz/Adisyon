using Auth.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auth.Dataaccess
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AccesstokenEntity> Accesstokens { get; set; }

    }
}
