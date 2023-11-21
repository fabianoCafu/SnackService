using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnackService.Api.Model;

namespace SnackService.Api.Map
{
    public class OrderedMap : IEntityTypeConfiguration<Ordered>
    {
        public void Configure(EntityTypeBuilder<Ordered> modelBuilder)
        {
            modelBuilder.ToTable("Pedidos");

            modelBuilder.HasKey(o => o.Id);

            modelBuilder.HasOne(o => o.Customer)
                        .WithMany(o => o.Ordered)
                        .HasForeignKey(o => o.CustomerId)
                        .IsRequired();

            modelBuilder.HasOne(o => o.Deliveryman)
                        .WithMany(o => o.Ordered)
                        .HasForeignKey(o => o.DeliverymanId)
                        .IsRequired(false);

            modelBuilder.Property(c => c.DateHour)
                        .HasColumnName("DataHora")
                        .HasColumnType("Datetime");

            modelBuilder.Property(c => c.Description)
                        .HasColumnName("Descricao")
                        .HasColumnType("text")
                        .IsRequired();

            modelBuilder.Property(c => c.Status)
                       .HasColumnName("Status")
                       .HasColumnType("int")
                       .IsRequired();

            modelBuilder.Property(c => c.Observation)
                        .HasColumnName("Observacao")
                        .HasColumnType("text")
                        .IsRequired();
        }
    }
}
