using DotNetCore.Base.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dojo.DotNetCore.Challange.Data
{
    public class UserEntityMapping : BaseEntityMapping<User>
    {
        public override void MapEntity(EntityTypeBuilder<User> builder)
        {
        }
    }
}