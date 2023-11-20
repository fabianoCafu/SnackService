using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnackService.Api.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Sexo = table.Column<string>(type: "char(1)", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "DateTime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entregadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insumos_Categorias_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliverymanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataHora = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Entregadores_DeliverymanId",
                        column: x => x.DeliverymanId,
                        principalTable: "Entregadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descricao", "Observacao", "Status" },
                values: new object[,]
                {
                    { new Guid("bb02fb2c-df70-45a8-ac2d-60b80d85095b"), "Destaques de Ofertas", "", 1 },
                    { new Guid("359e7095-85db-4a56-bf08-31cc8abbdcdf"), "Bebidas", "Não trabalhanos com Coca-Cola Light", 1 },
                    { new Guid("bd4a14a1-79f7-400d-a576-7a83e0fc2a7b"), "Açaís", "", 1 },
                    { new Guid("808017c9-40b6-40e2-a002-b4ba28f4bc13"), "Pastéis", "", 1 },
                    { new Guid("d94b460f-7eee-47d6-aeaa-593206895612"), "Dog", "", 1 },
                    { new Guid("f2d8d867-6cf2-4d17-99d0-cb7eaf81fb80"), "Xis", "", 1 },
                    { new Guid("2a045466-a466-4a11-a85e-9277f1f4dd8e"), "Promoção de Pizzas", "", 1 },
                    { new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Alaminutas", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Endereco", "Cidade", "Cpf", "DataDeNascimento", "Nome", "Bairro", "Numero", "Sexo", "Telefone", "Cep" },
                values: new object[,]
                {
                    { new Guid("22269b91-2f27-4c83-91ab-ae6773a8ad75"), "Rua Cherobina de Carvalho Pinto", "Aracaju", "26116317006", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3383), "Luis Marcelo da Silva Cunha", "Jardins", 127, "M", "51933389541", "49025820" },
                    { new Guid("ba34b384-b580-42d2-99f8-36b32ded911d"), "Rua Ayrton Senna", "Blumenau", "04609615002", new DateTime(2023, 11, 19, 23, 35, 8, 182, DateTimeKind.Local).AddTicks(9602), "Marcia Pereira dos Santos", "Água Verde", 6548, "F", "51985650321", "89037362" },
                    { new Guid("9a8d906f-cfed-4c25-a71d-0eaeae8864cb"), "Rua Valdyr Grando", "Curitiba", "35664447079", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3337), "Lauro da Silva da Cunha", "Cidade Industrial", 62, "M", "51985650888", "81310370" },
                    { new Guid("97bc85a4-a519-48e0-9353-be637a06cfd4"), "Rua Inspetor Miguel Amorim", "Macapá", "87270897034", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3317), "João da Rosa Martins Pereira", "Universidade", 562, "M", "51986325321", "68903517" },
                    { new Guid("f1af47a1-b3e7-49a5-86aa-58b5d0040227"), "Rua do Comércio", "Maringá", "72241909009", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3379), "Isabel Borba da Silva", "Zona 06", 77, "F", "51933353621", "87080180" },
                    { new Guid("ffbca445-aca3-4aad-86cb-1a169146464c"), "Rua da Praça", "Maranguape", "75367668070", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3342), "Jaqueline da Rosa Martins", "Novo Maranguape I", 77, "F", "519856450321", "61943015" },
                    { new Guid("afec2c8d-8376-4e56-b1e0-e24f57ea2cc7"), "Rua Mário Mendes de Lara", "Curitiba", "48490807078", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3345), "Claudio Nascimento do Santos", "Uberaba", 3021, "M", "51985600021", "81570200" },
                    { new Guid("e79de945-ef33-4bf4-bf92-0d7c71da252b"), "Rua Domingos Leite", "Parnaíba", "83241546047", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3376), "Jurema da Rosa Martins", "São José", 352, "F", "51933350321", "64218050" },
                    { new Guid("1f5605c7-ae5e-497a-bdc7-2b5406737b31"), "Rua Piauí", "Imperatriz", "93852857007", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3349), "Juliano Pereira da Silva", "Centro", 56, "M", "51989650321", "65901600" },
                    { new Guid("482031a5-c907-4969-ba9f-5347b15177d4"), "Rua das Algas Marinhas", "Parnamirim", "72155881061", new DateTime(2023, 11, 19, 23, 35, 8, 184, DateTimeKind.Local).AddTicks(3353), "Carlos Pereira da Silva", "Bela Parnamirim", 623, "M", "51985999321", "59142505" }
                });

            migrationBuilder.InsertData(
                table: "Entregadores",
                columns: new[] { "Id", "Cpf", "Nome", "Status", "Telefone" },
                values: new object[,]
                {
                    { new Guid("a1badae8-617c-4dde-b125-effd3a7310f6"), "84481330058", "Renato Borges do Santos", 1, "51986541236" },
                    { new Guid("5775a3c5-06bc-43f7-959b-0a3b4f7ba7ac"), "51442876034", "Jaqueline da Rocha Martins", 1, "51986532541" },
                    { new Guid("c3c768d4-0cec-4c12-9a20-92db91012b1a"), "32578255016", "Luiz da Silva Pereira do Santos", 1, "5198632541" },
                    { new Guid("af54c80e-ffde-425c-9c65-da55e2200360"), "99026185022", "Marcelo Guimarãoes da Rosa", 1, "51994530126" },
                    { new Guid("94ace7c7-2167-4b99-9f3d-f5e442cc5ae9"), "18087267079", "Eduardo Gonsalves da Silva", 1, "51986532104" }
                });

            migrationBuilder.InsertData(
                table: "Insumos",
                columns: new[] { "Id", "CategoryId", "Descricao", "Observacao", "Status" },
                values: new object[,]
                {
                    { new Guid("ac515b07-a7b6-47c9-ae8b-c87b9ac69415"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Salada", "", 1 },
                    { new Guid("56835e41-3146-44f5-8aba-ce9f25809466"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Bife de Gado", "", 1 },
                    { new Guid("c083e644-b780-4131-b413-75aecff63483"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Bife de Frango", "", 1 },
                    { new Guid("68169a36-eef0-45d8-95ee-a527a3170fa7"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Filé de Peixe", "", 1 },
                    { new Guid("9e3fcefa-3155-4e88-81cf-4318cf6bbeb7"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Chuleta gado Acebolada", "", 1 },
                    { new Guid("de2174ff-9224-4360-94ca-7d73b8d74ede"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Chuleta de gado", "", 1 },
                    { new Guid("2cb33eb5-23d2-4612-8ece-6d97ee1893d9"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Bife á parmediana", "", 1 },
                    { new Guid("fed45af9-9e0f-49fc-b5b5-136af314b834"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Porção de Arroz", "", 1 },
                    { new Guid("1d3c6fed-a7c3-4904-8fdf-dc24ee8f5870"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Porção de Feijão", "", 1 },
                    { new Guid("e63b618f-04fe-4d1a-94ce-ea8cec3704ee"), new Guid("0be28306-4956-445e-aab8-f1f93a494cd9"), "Porção de Massa", "", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insumos_CategoryId",
                table: "Insumos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CustomerId",
                table: "Pedidos",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DeliverymanId",
                table: "Pedidos",
                column: "DeliverymanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Entregadores");
        }
    }
}
