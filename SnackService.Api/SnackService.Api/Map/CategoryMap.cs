using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnackService.Api.Models;

namespace SnackService.Api.Map
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            modelBuilder.ToTable("Categorias");

            modelBuilder.HasKey(c => c.Id);

            modelBuilder.Property(c => c.Description)
                        .HasColumnName("Descricao")
                        .HasColumnType("text");

            modelBuilder.Property(c => c.Status)
                        .HasColumnName("Status")
                        .HasColumnType("int")
                        .IsRequired();

            modelBuilder.Property(c => c.Observation)
                      .HasColumnName("Observacao")
                      .HasColumnType("text")
                      .IsRequired(false);
        }
    }
}
