using SnackService.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using SnackService.Api.Enum;

namespace SnackService.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deliveryman> Deliverymans { get; set; }
        public DbSet<Ordered> Ordereds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomersTableConfiguration(modelBuilder);
            DeliverymansTableConfiguration(modelBuilder);
            OrderedsTableConfiguration(modelBuilder);

            #region Inserção Clientes

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Marcia Pereira dos Santos",
                    Cpf = "04609615002",
                    Telephone = "51985650321",
                    ZipCode = "89037362",
                    Address = "Rua Ayrton Senna",
                    Number = 6548,
                    Neighborhood = "Água Verde",
                    City = "Blumenau",
                    Sex = CustomerSex.Feminine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "João da Rosa Martins Pereira",
                    Cpf = "87270897034",
                    Telephone = "51986325321",
                    ZipCode = "68903517",
                    Address = "Rua Inspetor Miguel Amorim",
                    Number = 562,
                    Neighborhood = "Universidade",
                    City = "Macapá",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Lauro da Silva da Cunha",
                    Cpf = "35664447079",
                    Telephone = "51985650888",
                    ZipCode = "81310370",
                    Address = "Rua Valdyr Grando",
                    Number = 62,
                    Neighborhood = "Cidade Industrial",
                    City = "Curitiba",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Jaqueline da Rosa Martins",
                    Cpf = "75367668070",
                    Telephone = "519856450321",
                    ZipCode = "61943015",
                    Address = "Rua da Praça",
                    Number = 77,
                    Neighborhood = "Novo Maranguape I",
                    City = "Maranguape",
                    Sex = CustomerSex.Feminine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Claudio Nascimento do Santos",
                    Cpf = "48490807078",
                    Telephone = "51985600021",
                    ZipCode = "81570200",
                    Address = "Rua Mário Mendes de Lara",
                    Number = 3021,
                    Neighborhood = "Uberaba",
                    City = "Curitiba",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Juliano Pereira da Silva",
                    Cpf = "93852857007",
                    Telephone = "51989650321",
                    ZipCode = "65901600",
                    Address = "Rua Piauí",
                    Number = 56,
                    Neighborhood = "Centro",
                    City = "Imperatriz",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Carlos Pereira da Silva",
                    Cpf = "72155881061",
                    Telephone = "51985999321",
                    ZipCode = "59142505",
                    Address = "Rua das Algas Marinhas",
                    Number = 623,
                    Neighborhood = "Bela Parnamirim",
                    City = "Parnamirim",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Jurema da Rosa Martins",
                    Cpf = "83241546047",
                    Telephone = "51933350321",
                    ZipCode = "64218050",
                    Address = "Rua Domingos Leite",
                    Number = 352,
                    Neighborhood = "São José",
                    City = "Parnaíba",
                    Sex = CustomerSex.Feminine,
                    DateOfBirth = DateTime.Now
                },

                new Customer
                {
                     Id = Guid.NewGuid(),
                     Name = "Isabel Borba da Silva",
                     Cpf = "72241909009",
                     Telephone = "51933353621",
                     ZipCode = "87080180",
                     Address = "Rua do Comércio",
                     Number = 77,
                     Neighborhood = "Zona 06",
                     City = "Maringá",
                     Sex = CustomerSex.Feminine,
                     DateOfBirth = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Luis Marcelo da Silva Cunha",
                    Cpf = "26116317006",
                    Telephone = "51933389541",
                    ZipCode = "49025820",
                    Address = "Rua Cherobina de Carvalho Pinto",
                    Number = 127,
                    Neighborhood = "Jardins",
                    City = "Aracaju",
                    Sex = CustomerSex.Masculine,
                    DateOfBirth = DateTime.Now
                }
            );

            #endregion


            //modelBuilder.Entity<Deliveryman>().HasData(
            //    new Deliveryman
            //    {

            //    });

            //modelBuilder.Entity<Ordered>().HasData(
            //    new Ordered
            //    {

            //    });
        }

        private static void CustomersTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("Clientes");

            //modelBuilder.Entity<Customer>() 
            //    .Property(x => x.Id)
            //    .HasConversion(
            //        v => v.ToString(),
            //        v => Guid.Parse(v)) 
            //    .HasColumnName("Id");
            
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);
            
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Cpf)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Telephone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Address)
                .HasColumnName("Endereco")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Number)
                .HasColumnName("Numero")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Neighborhood)
                .HasColumnName("Bairro")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.City)
                .HasColumnName("Cidade")
                .HasColumnType("varchar")
                .HasMaxLength(80)
               .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.ZipCode)
                .HasColumnName("Cep")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Sex)
                .HasColumnName("Sexo")
                .HasColumnType("char")
                .IsRequired(false);

            modelBuilder.Entity<Customer>()
                .Property(c => c.DateOfBirth)
                .HasColumnName("DataDeNascimento")
                .HasColumnType("Date");
        }

        private static void DeliverymansTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deliveryman>()
                .ToTable("Entregadores");

            modelBuilder.Entity<Deliveryman>()
                .HasKey(c => c.Id);

        }

        private static void OrderedsTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ordered>()
                .ToTable("Pedidos");

            modelBuilder.Entity<Ordered>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Ordered>()
                .Property(c => c.CustomerId)
                .HasColumnName("ClienteId")
                .HasColumnType("uniqueidentifier");

            //modelBuilder.Entity<Ordered>()
            //    .HasOne(o => o.Customer)
            //    .WithMany(o => o.Id)
            //    .HasForeignKey(o => o.CustomerId)
            //    .HasConstraintName("FK_ClientePedidos");

            modelBuilder.Entity<Ordered>()
                .HasOne(o => o.Deliveryman)
                .WithMany(o => o.Ordered)
                .HasForeignKey(o => o.DeliverymanId)
                .HasConstraintName("FK_ClienteEntregadores");

            modelBuilder.Entity<Ordered>()
                .Property(c => c.Date)
                .HasColumnName("DataPedido")
                .HasColumnType("Datetime2");

            modelBuilder.Entity<Ordered>()
                .Property(c => c.Hour)
                .HasColumnName("HoraPedido")
                .HasColumnType("Datetime2");

            modelBuilder.Entity<Ordered>()
                .Property(c => c.Description)
                .HasColumnName("DescricaoPedido")
                .HasColumnType("text")
                .IsRequired();

            modelBuilder.Entity<Ordered>()
                .Property(c => c.StatusType)
                .HasColumnName("StatusPedido")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
