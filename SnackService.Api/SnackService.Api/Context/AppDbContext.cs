using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Linq;
using SnackService.Api.Enum;
using SnackService.Api.Model;
using SnackService.Api.Models;
using System;

namespace SnackService.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deliveryman> Deliverymans { get; set; }
        public DbSet<Ordered> Ordereds { get; set; }

        //public DbSet<Additional> Additionals { get; set; }
        //public DbSet<Input> OrderAdditional { get; set; }
        public DbSet<Category> Categorys { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomersTableConfiguration(modelBuilder);
            DeliverymansTableConfiguration(modelBuilder);
            OrderedsTableConfiguration(modelBuilder);

            //AdditionalsTableCpnfiguration(modelBuilder);
            //CategorysTableConfiguration(modelBuilder);

            CategorysTableConfiguration(modelBuilder);
            InputsTableConfiguration(modelBuilder);

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
                    Sex = (char)EnumSex.Feminine,
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
                    Sex = (char)EnumSex.Masculine,
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
                    Sex = (char)EnumSex.Masculine,
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
                    Sex = (char)EnumSex.Feminine,
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
                    Sex = (char)EnumSex.Masculine,
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
                    Sex = (char)EnumSex.Masculine,
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
                    Sex = (char)EnumSex.Masculine,
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
                    Sex = (char)EnumSex.Feminine,
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
                    Sex = (char)EnumSex.Feminine,
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
                    Sex = (char)EnumSex.Masculine,
                    DateOfBirth = DateTime.Now
                }
            );

            modelBuilder.Entity<Deliveryman>().HasData(
                new Deliveryman
                {
                    Id = Guid.NewGuid(),
                    Name = "Renato Borges do Santos",
                    Telephone = "51986541236",
                    Cpf = "84481330058",
                    Status = 1
                },
                new Deliveryman
                {
                    Id = Guid.NewGuid(),
                    Name = "Eduardo Gonsalves da Silva",
                    Telephone = "51986532104",
                    Cpf = "18087267079",
                    Status = 1
                },
                new Deliveryman
                {
                    Id = Guid.NewGuid(),
                    Name = "Marcelo Guimarãoes da Rosa",
                    Telephone = "51994530126",
                    Cpf = "99026185022",
                    Status = 1
                },
                new Deliveryman
                {
                    Id = Guid.NewGuid(),
                    Name = "Luiz da Silva Pereira do Santos",
                    Telephone = "5198632541",
                    Cpf = "32578255016",
                    Status = 1
                },
                new Deliveryman
                {
                    Id = Guid.NewGuid(),
                    Name = "Jaqueline da Rocha Martins",
                    Telephone = "51986532541",
                    Cpf = "51442876034",
                    Status = 1
                }
            );

            //modelBuilder.Entity<OrderAdditional>().HasData(
            //    new OrderAdditional
            //    {

            //    }
            //);


            //modelBuilder.Entity<Ordered>().HasData(
            //    new Ordered
            //    {

            //    });

            //modelBuilder.Entity<Additiona>().HasData(
            //    new Additiona
            //    {

            //    });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Alaminutas",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active

                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Destaques de Ofertas",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                }, 
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Promoção de Pizzas",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Xis",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Dog",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Pastéis",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Açaís",
                    Observation = string.Empty,
                    Status = (int)EnumStatus.Active
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Description = "Bebidas",
                    Observation = "Não trabalhanos com Coca-Cola Light",
                    Status = (int)EnumStatus.Active
                }
            );

            modelBuilder.Entity<Input>().HasData(
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Salada",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Bife de Gado",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Bife de Frango",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Filé de Peixe",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Chuleta gado Acebolada",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Chuleta de gado",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Bife á parmediana",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(),//Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Porção de Arroz",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Porção de Feijão",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                },
                new Input
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(), //Guid.Parse("8EF11760-CAFE-468F-9102-13D295150DE6"),
                    Description = "Porção de Massa",
                    Status = (int)EnumStatus.Active,
                    Observation = string.Empty
                }
            );

            #endregion
        }

        private static void CustomersTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                        .ToTable("Clientes");

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
                        .IsUnicode()
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
                        .IsRequired();

            modelBuilder.Entity<Customer>()
                        .Property(c => c.DateOfBirth)
                        .HasColumnName("DataDeNascimento")
                        .HasColumnType("DateTime2");
        }

        private static void DeliverymansTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deliveryman>()
                        .ToTable("Entregadores");

            modelBuilder.Entity<Deliveryman>()
                        .HasKey(c => c.Id);

            modelBuilder.Entity<Deliveryman>()
                        .Property(c => c.Name)
                        .HasColumnName("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(80)
                        .IsRequired();

            modelBuilder.Entity<Deliveryman>()
                        .Property(c => c.Telephone)
                        .HasColumnName("Telefone")
                        .HasColumnType("varchar")
                        .HasMaxLength(14)
                        .IsRequired();

            modelBuilder.Entity<Deliveryman>()
                        .Property(c => c.Cpf)
                        .IsUnicode()
                        .HasColumnType("varchar")
                        .HasMaxLength(11)
                        .IsRequired();

            modelBuilder.Entity<Deliveryman>()
                        .Property(c => c.Status)
                        .HasColumnName("Status")
                        .HasColumnType("int")
                        .IsRequired();

        }

        private static void OrderedsTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ordered>()
                        .ToTable("Pedidos");

            modelBuilder.Entity<Ordered>()
                        .HasKey(o => o.Id);

            modelBuilder.Entity<Ordered>()
                        .HasOne(o => o.Customer)
                        .WithMany(o => o.Ordered)
                        .HasForeignKey(o => o.CustomerId)
                        .IsRequired();
            
            modelBuilder.Entity<Ordered>()
                        .HasOne(o => o.Deliveryman)
                        .WithMany(o => o.Ordered)
                        .HasForeignKey(o => o.DeliverymanId)
                        .IsRequired(false);

            modelBuilder.Entity<Ordered>()
                        .Property(c => c.DateHour)
                        .HasColumnName("DataHora")
                        .HasColumnType("Datetime");

            modelBuilder.Entity<Ordered>()
                        .Property(c => c.Description)
                        .HasColumnName("Descricao")
                        .HasColumnType("text")
                        .IsRequired();

            modelBuilder.Entity<Ordered>()
                       .Property(c => c.Status)
                       .HasColumnName("Status")
                       .HasColumnType("int")
                       .IsRequired();

            modelBuilder.Entity<Ordered>()
                        .Property(c => c.Observation)
                        .HasColumnName("Observacao")
                        .HasColumnType("text")
                        .IsRequired();
        }

        private static void CategorysTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .ToTable("Categorias");

            modelBuilder.Entity<Category>()
                        .HasKey(c => c.Id);

            modelBuilder.Entity<Category>()
                        .Property(c => c.Description)
                        .HasColumnName("Descricao")
                        .HasColumnType("text");

            modelBuilder.Entity<Category>()
                        .Property(c => c.Status)
                        .HasColumnName("Status")
                        .HasColumnType("int")
                        .IsRequired();

            modelBuilder.Entity<Category>()
                      .Property(c => c.Observation)
                      .HasColumnName("Observacao")
                      .HasColumnType("text")
                      .IsRequired(false);

        }




        private static void InputsTableConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Input>()
                        .ToTable("Insumos");

            modelBuilder.Entity<Input>()
                        .HasKey(c => c.Id);

            modelBuilder.Entity<Input>()
                        .HasOne(o => o.Category)
                        .WithMany(o => o.Input)
                        .HasForeignKey(o => o.CategoryId)
                        .IsRequired();

            modelBuilder.Entity<Input>()
                        .Property(c => c.Description)
                        .HasColumnName("Descricao")
                        .HasColumnType("text");

            modelBuilder.Entity<Input>()
                        .Property(c => c.Status)
                        .HasColumnName("Status")
                        .HasColumnType("int")
                        .IsRequired();

            modelBuilder.Entity<Input>()
                        .Property(c => c.Observation)
                        .HasColumnName("Observacao")
                        .HasColumnType("text")
                        .IsRequired(false);
        }




        //private static void AdditionalsTableConfiguration(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Additional>()
        //                .ToTable("Adicionais");

        //    modelBuilder.Entity<Additional>()
        //                .HasKey(c => c.Id);

        //    //modelBuilder.Entity<Additional>()
        //    //           .HasOne(o => o.Category)
        //    //           .WithMany(o => o.)
        //    //           .HasForeignKey(o => o.CategoryId)
        //    //           .HasConstraintName("FK_CategoriaAdicional");

        //    modelBuilder.Entity<Additional>()
        //                .Property(c => c.Description)
        //                .HasColumnName("Descricao")
        //                .HasColumnType("varchar")
        //                .HasMaxLength(80)
        //                .IsRequired();

        //    modelBuilder.Entity<Additional>()
        //                .Property(c => c.Status)
        //                .HasColumnName("Ativo")
        //                .HasColumnType("int")
        //                .IsRequired();
        //}

        //private static void OrderAdditionalTableConfiguration(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Input>()
        //                .ToTable("AdicionalPedidos");

        //    modelBuilder.Entity<Input>()
        //                .HasKey(c => c.Id);

        //    modelBuilder.Entity<Input>()
        //               .HasOne(o => o.Ordered)
        //               .WithMany(o => o.OrderAdditionals)
        //               .HasForeignKey(o => o.OrderedId)
        //               .HasConstraintName("FK_PedidoAdicional");

        //    //modelBuilder.Entity<OrderAdditional>()
        //    //           .HasOne(o => o.Additional)
        //    //           .WithMany(o => o.OrderAdditiona)
        //    //           .HasForeignKey(o => o.)
        //    //           .HasConstraintName("FK_AdicionalAdicionalPedido");

        //    modelBuilder.Entity<Input>()
        //               .Property(c => c.Amount)
        //               .HasColumnName("Quantidade")
        //               .HasColumnType("int")
        //               .IsRequired();


        //    /*
        //     Id 
        //     OrderedId 
        //     AdditionalId 
        //     Amount 
        //    */
        //}
    }
}

