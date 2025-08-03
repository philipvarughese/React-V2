using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                   table: "Products",
                   columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
                   values: new object[]
                {
                    "Angular Speedster Board 2000",
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    20000,
                    "/images/products/sb-ang1.png",
                    "Angular",
                    "Boards",
                    100
                });

            migrationBuilder.InsertData(
              table: "Products",
              columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
              values: new object[]
           {
                     "Green Angular Board 3000",
                     "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                     15000,
                     "/images/products/sb-ang2.png",
                    "Angular",
                    "Boards",
                     100
           });

            migrationBuilder.InsertData(
                  table: "Products",
                  columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
                  values: new object[]

           {
                "Core Board Speed Rush 3",
                                  "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                18000,
                "/images/products/sb-core1.png",
                "NetCore",
                "Boards",
                100
           });

            migrationBuilder.InsertData(
                   table: "Products",
                   columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
                   values: new object[]
                   {
                 "Net Core Super Board",
                 "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                 30000,
                 "/images/products/sb-core2.png",
                 "NetCore",
                "Boards",
                100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[] {
                     "React Board Super Whizzy Fast",
                     "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     25000,
                     "/images/products/sb-react1.png",
                     "React",
                     "Boards",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                    "Typescript Entry Board",

                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     12000,
                     "/images/products/sb-ts1.png",
                    "TypeScript",
                    "Boards",
                    100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                    "Core Blue Hat",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     1000,
                    "/images/products/hat-core1.png",
                    "netCore",
                     "Hats",
                    100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                    "Green React Woolen Hat",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     8000,
                     "/images/products/hat-react1.png",
                     "React",
                     "Hats",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                     "Purple React Woolen Hat",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     1500,
                     "/images/products/hat-react2.png",
                    "React",
                    "Hats",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                    "Blue Code Gloves",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     1800,
                     "/images/products/glove-code1.png",
                    "VS Code",
                     "Gloves",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                    "Green Code Gloves",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     1500,
                     "/images/products/glove-code2.png",
                     "VS Code",
                     "Gloves",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                     "Purple React Gloves",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    1600,
                    "/images/products/glove-react1.png",
                    "React",
                     "Gloves",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                     "Green React Gloves",

                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     1400,
                    "/images/products/glove-react2.png",
                    "React",
                     "Gloves",
                     100
            });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
            {
                     "Redis Red Boots",

                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                     25000,
                     "/images/products/boot-redis1.png",
                    "Redis",
                     "Boots",
                     100
            });
            migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
            values: new object[]
             {
                    "Core Red Boots",

                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     18999,
                    "/images/products/boot-core2.png",
                     "NetCore",
                    "Boots",
                     100
             });
            migrationBuilder.InsertData(
          table: "Products",
          columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
          values: new object[]
           {
                     "Core Purple Boots",

                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                     19999,
                     "/images/products/boot-core1.png",
                     "NetCore",
                     "Boots",
                     100
           });
            migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
            values: new object[]
             {
                    "Angular Purple Boots",
                    "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    15000,
                     "/images/products/boot-ang2.png",
                     "Angular",
                     "Boots",
                     100
             });
                 migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "Name", "Description", "Price", "PictureUrl", "Type", "Brand", "QuantityInStock" },
               values: new object[]
                {
                     "Angular Blue Boots",
                                            "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                     18000,
                     "/images/products/boot-ang1.png",
                     "Angular",
                     "Boots",
                     100
                }

            );   
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
