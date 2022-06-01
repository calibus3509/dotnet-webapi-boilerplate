using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    public partial class MoreDogShowStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Dsc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogShows",
                schema: "Dsc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntryFee = table.Column<double>(type: "float", nullable: true),
                    Distance = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogShows_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "Dsc",
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "People",
                schema: "Dsc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "Dsc",
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DogShowClasses",
                schema: "Dsc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RingNumber = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JudgeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DogShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogShowClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogShowClasses_DogBreeds_BreedId",
                        column: x => x.BreedId,
                        principalSchema: "Dsc",
                        principalTable: "DogBreeds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DogShowClasses_DogShows_DogShowId",
                        column: x => x.DogShowId,
                        principalSchema: "Dsc",
                        principalTable: "DogShows",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DogShowClasses_People_JudgeId",
                        column: x => x.JudgeId,
                        principalSchema: "Dsc",
                        principalTable: "People",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DogShowClassCategories",
                schema: "Dsc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogShowClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogShowClassCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogShowClassCategories_DogShowClasses_DogShowClassId",
                        column: x => x.DogShowClassId,
                        principalSchema: "Dsc",
                        principalTable: "DogShowClasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                column: "DogShowClassCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DogShowClassCategories_DogShowClassId",
                schema: "Dsc",
                table: "DogShowClassCategories",
                column: "DogShowClassId");

            migrationBuilder.CreateIndex(
                name: "IX_DogShowClasses_BreedId",
                schema: "Dsc",
                table: "DogShowClasses",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_DogShowClasses_DogShowId",
                schema: "Dsc",
                table: "DogShowClasses",
                column: "DogShowId");

            migrationBuilder.CreateIndex(
                name: "IX_DogShowClasses_JudgeId",
                schema: "Dsc",
                table: "DogShowClasses",
                column: "JudgeId");

            migrationBuilder.CreateIndex(
                name: "IX_DogShows_AddressId",
                schema: "Dsc",
                table: "DogShows",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_People_AddressId",
                schema: "Dsc",
                table: "People",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogShowClassCategories_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                column: "DogShowClassCategoryId",
                principalSchema: "Dsc",
                principalTable: "DogShowClassCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogShowClassCategories_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");

            migrationBuilder.DropTable(
                name: "DogShowClassCategories",
                schema: "Dsc");

            migrationBuilder.DropTable(
                name: "DogShowClasses",
                schema: "Dsc");

            migrationBuilder.DropTable(
                name: "DogShows",
                schema: "Dsc");

            migrationBuilder.DropTable(
                name: "People",
                schema: "Dsc");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Dsc");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");
        }
    }
}
