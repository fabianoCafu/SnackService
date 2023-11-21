using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnackService.Api.Model;
using System.Reflection.Emit;

namespace SnackService.Api.Map
{
    public class DeliverymanMap : IEntityTypeConfiguration<Deliveryman>
    {
        public void Configure(EntityTypeBuilder<Deliveryman> modelBuilder)
        {
            modelBuilder.ToTable("Entregadores");

            modelBuilder.HasKey(c => c.Id);

            modelBuilder.Property(c => c.Name)
                        .HasColumnName("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(80)
                        .IsRequired();

            modelBuilder.Property(c => c.Telephone)
                        .HasColumnName("Telefone")
                        .HasColumnType("varchar")
                        .HasMaxLength(14)
                        .IsRequired();

            modelBuilder.Property(c => c.Cpf)
                        .IsUnicode()
                        .HasColumnType("varchar")
                        .HasMaxLength(11)
                        .IsRequired();

            modelBuilder.Property(c => c.Status)
                        .HasColumnName("Status")
                        .HasColumnType("int")
                        .IsRequired();
        }
    }
}
