using DotNetCore.Base.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dojo.DotNetCore.Challange.Data
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureInvoicingEntities();
        }
    }
}