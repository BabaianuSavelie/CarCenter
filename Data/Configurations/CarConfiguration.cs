using CarCenter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCenter.Data.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.HasOne(x => x.Model)
            .WithMany()
            .HasForeignKey(x => x.ModelId);


        builder.HasOne(c => c.Brand)
            .WithMany()
            .HasForeignKey(c=>c.BrandId);
    }
}
