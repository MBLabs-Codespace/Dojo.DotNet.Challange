using Microsoft.EntityFrameworkCore;

namespace Dojo.DotNetCore.Challange.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }
    }
}