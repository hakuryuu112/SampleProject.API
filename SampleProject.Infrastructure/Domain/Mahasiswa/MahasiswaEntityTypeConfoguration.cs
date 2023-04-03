using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Domain.Mahasiswa;


namespace SampleProject.Infrastructure.Domain.Mahasiswa
{
    internal sealed class MahasiswaEntityTypeConfoguration : IEntityTypeConfiguration<Mahasiswas>
    {
        public void Configure(EntityTypeBuilder<Mahasiswas> builder)
        {
            builder.ToTable("Mahasiswa", SchemaNames.dbo);

            builder.HasKey(b => b.id);

            builder.Property("_name").HasColumnName("name");
            builder.Property("_nim").HasColumnName("nim");
            builder.Property("_sex").HasColumnName("sex");
            builder.Property("_city").HasColumnName("city");
            builder.Property("_country").HasColumnName("country");
            builder.Property("_date").HasColumnName("date");
            builder.Property("_address").HasColumnName("address");
        }
    }
}
