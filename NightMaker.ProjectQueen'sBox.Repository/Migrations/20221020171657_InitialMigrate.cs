using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NightMaker.ProjectQueen_sBox.Repository.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeehiveDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modernity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeehiveDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeehiveMaintenanceStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastMaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCriticalAlert = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeehiveMaintenanceStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeehiveNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeehiveNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColonyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MountUntilLastHarvest = table.Column<int>(type: "int", nullable: false),
                    MountUntilLastBreed = table.Column<int>(type: "int", nullable: false),
                    ApproximateBeeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColonyMaintenanceStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastBreedAttempt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastMedicalIntervention = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCriticalAlert = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyMaintenanceStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColonyNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColonyStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoneyKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeeWaxKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeePoisonKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraNutritionKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColonyStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProducerStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoneyKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeeWaxKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeePoisonKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ColonyCount = table.Column<int>(type: "int", nullable: false),
                    FreeBeeBoxCount = table.Column<int>(type: "int", nullable: false),
                    TotalLayerCount = table.Column<int>(type: "int", nullable: false),
                    ApproximateHoneyHarvestKG = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApproximateBeeWaxHarvestKG = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApproximateBeePoisonHarvestKG = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colonies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueenId = table.Column<int>(type: "int", nullable: false),
                    ColonyMaintenanceStatusId = table.Column<int>(type: "int", nullable: false),
                    ColonyNoteId = table.Column<int>(type: "int", nullable: false),
                    ColonyStockId = table.Column<int>(type: "int", nullable: false),
                    ColonyDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colonies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colonies_ColonyDetails_ColonyDetailId",
                        column: x => x.ColonyDetailId,
                        principalTable: "ColonyDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colonies_ColonyMaintenanceStatuses_ColonyMaintenanceStatusId",
                        column: x => x.ColonyMaintenanceStatusId,
                        principalTable: "ColonyMaintenanceStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colonies_ColonyNotes_ColonyNoteId",
                        column: x => x.ColonyNoteId,
                        principalTable: "ColonyNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colonies_ColonyStocks_ColonyStockId",
                        column: x => x.ColonyStockId,
                        principalTable: "ColonyStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colonies_Queens_QueenId",
                        column: x => x.QueenId,
                        principalTable: "Queens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beehives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeehiveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColonyId = table.Column<int>(type: "int", nullable: false),
                    BeehiveDetailId = table.Column<int>(type: "int", nullable: false),
                    BeehiveMaintenanceStatusId = table.Column<int>(type: "int", nullable: false),
                    BeehiveNoteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beehives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beehives_BeehiveDetails_BeehiveDetailId",
                        column: x => x.BeehiveDetailId,
                        principalTable: "BeehiveDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beehives_BeehiveMaintenanceStatuses_BeehiveMaintenanceStatusId",
                        column: x => x.BeehiveMaintenanceStatusId,
                        principalTable: "BeehiveMaintenanceStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beehives_BeehiveNotes_BeehiveNoteId",
                        column: x => x.BeehiveNoteId,
                        principalTable: "BeehiveNotes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Beehives_Colonies_ColonyId",
                        column: x => x.ColonyId,
                        principalTable: "Colonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Harvests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoneyKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeeWaxKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeePoisonKG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HarvestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColonyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harvests_Colonies_ColonyId",
                        column: x => x.ColonyId,
                        principalTable: "Colonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_BeehiveDetailId",
                table: "Beehives",
                column: "BeehiveDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_BeehiveMaintenanceStatusId",
                table: "Beehives",
                column: "BeehiveMaintenanceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_BeehiveNoteId",
                table: "Beehives",
                column: "BeehiveNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_ColonyId",
                table: "Beehives",
                column: "ColonyId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ColonyDetailId",
                table: "Colonies",
                column: "ColonyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ColonyMaintenanceStatusId",
                table: "Colonies",
                column: "ColonyMaintenanceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ColonyNoteId",
                table: "Colonies",
                column: "ColonyNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_ColonyStockId",
                table: "Colonies",
                column: "ColonyStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Colonies_QueenId",
                table: "Colonies",
                column: "QueenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Harvests_ColonyId",
                table: "Harvests",
                column: "ColonyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beehives");

            migrationBuilder.DropTable(
                name: "Harvests");

            migrationBuilder.DropTable(
                name: "ProducerStocks");

            migrationBuilder.DropTable(
                name: "BeehiveDetails");

            migrationBuilder.DropTable(
                name: "BeehiveMaintenanceStatuses");

            migrationBuilder.DropTable(
                name: "BeehiveNotes");

            migrationBuilder.DropTable(
                name: "Colonies");

            migrationBuilder.DropTable(
                name: "ColonyDetails");

            migrationBuilder.DropTable(
                name: "ColonyMaintenanceStatuses");

            migrationBuilder.DropTable(
                name: "ColonyNotes");

            migrationBuilder.DropTable(
                name: "ColonyStocks");

            migrationBuilder.DropTable(
                name: "Queens");
        }
    }
}
