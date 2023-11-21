using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnackService.Api.Models;

namespace SnackService.Api.Map
{
    public class InputMap : IEntityTypeConfiguration<Input>
    {
        public void Configure(EntityTypeBuilder<Input> modelBuilder)
        {
            modelBuilder.ToTable("Insumos");

            modelBuilder.HasKey(c => c.Id);

            modelBuilder.HasOne(o => o.Category)
                        .WithMany(o => o.Input)
                        .HasForeignKey(o => o.CategoryId)
                        .IsRequired();

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
