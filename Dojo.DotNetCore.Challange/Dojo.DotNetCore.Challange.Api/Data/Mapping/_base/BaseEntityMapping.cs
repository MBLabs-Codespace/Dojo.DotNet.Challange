using DotNetCore.Base.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dojo.DotNetCore.Challange.Data
{
    public abstract class BaseEntityMapping<E> : IEntityTypeConfiguration<E> where E : BaseModel
    {
        public void Configure(EntityTypeBuilder<E> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.CreatedBy)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(a => a.CreatedAt)
                .IsRequired();

            builder.Property(a => a.UpdatedBy)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(a => a.UpdatedAt)
                .IsRequired();

            MapEntity(builder);
        }

        public abstract void MapEntity(EntityTypeBuilder<E> builder);
    }
}