using Microsoft.EntityFrameworkCore;

namespace Dojo.DotNetCore.Challange.Data
{
    public static class EntityConfiguration
    {
        public static void ConfigureInvoicingEntities(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserEntityMapping());
        }
    }
}