using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentsManager.Domain.Entities;

namespace StudentsManager.Infrastructure.Persistence.Configurations;

public sealed class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");

        builder.HasKey(student => student.Id);

        builder.HasIndex(student => student.Name);

        builder.Property(student => student.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(student => student.BirthDate)
            .IsRequired();

        builder.Property(student => student.Grade)
            .IsRequired()
            .HasPrecision(3, 2);
    }
}