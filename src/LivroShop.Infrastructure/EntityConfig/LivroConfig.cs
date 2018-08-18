using LivroShop.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivroShop.Infrastructure.EntityConfig
{
    class LivroConfig : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(p => p.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome)
                   .HasColumnType("varchar(50)")
                   .IsRequired();
            builder.Property(p => p.ISBN)
                   .HasColumnType("varchar(10)")
                   .IsRequired();
        }
    }
}
