using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnackService.Api.Model;

namespace SnackService.Api.Map
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder.ToTable("Clientes");

            modelBuilder.HasKey(c => c.Id);

            modelBuilder.Property(c => c.Name)
                        .HasColumnName("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(80)
                        .IsRequired();

            modelBuilder.Property(c => c.Cpf)
                        .IsUnicode()
                        .HasColumnType("varchar")
                        .HasMaxLength(11)
                        .IsRequired();

            modelBuilder.Property(c => c.Telephone)
                        .HasColumnName("Telefone")
                        .HasColumnType("varchar")
                        .HasMaxLength(14)
                        .IsRequired();

            modelBuilder.Property(c => c.Address)
                        .HasColumnName("Endereco")
                        .HasColumnType("varchar")
                        .HasMaxLength(100)
                        .IsRequired();

            modelBuilder.Property(c => c.Number)
                        .HasColumnName("Numero")
                        .HasColumnType("int")
                        .IsRequired();

            modelBuilder.Property(c => c.Neighborhood)
                        .HasColumnName("Bairro")
                        .HasColumnType("varchar")
                        .HasMaxLength(80)
                        .IsRequired();

            modelBuilder.Property(c => c.City)
                        .HasColumnName("Cidade")
                        .HasColumnType("varchar")
                        .HasMaxLength(80)
                        .IsRequired();

            modelBuilder.Property(c => c.ZipCode)
                        .HasColumnName("Cep")
                        .HasColumnType("varchar")
                        .HasMaxLength(10)
                        .IsRequired();

            modelBuilder.Property(c => c.Sex)
                        .HasColumnName("Sexo")
                        .HasColumnType("char")
                        .IsRequired();

            modelBuilder.Property(c => c.DateOfBirth)
                        .HasColumnName("DataDeNascimento")
                        .HasColumnType("DateTime2");
        }
    }
}
