using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_cyberpunk_challenge_5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clusters",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    clusterName = table.Column<string>(type: "TEXT", nullable: false),
                    nodeCount = table.Column<int>(type: "INTEGER", nullable: false),
                    cpuCores = table.Column<int>(type: "INTEGER", nullable: false),
                    memoryGb = table.Column<int>(type: "INTEGER", nullable: false),
                    storageTb = table.Column<int>(type: "INTEGER", nullable: false),
                    creationDate = table.Column<string>(type: "TEXT", nullable: false),
                    environment = table.Column<string>(type: "TEXT", nullable: false),
                    kubernetesVersion = table.Column<string>(type: "TEXT", nullable: false),
                    region = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clusters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    publicKey = table.Column<string>(type: "TEXT", nullable: false),
                    architecture = table.Column<string>(type: "TEXT", nullable: false),
                    processorType = table.Column<string>(type: "TEXT", nullable: false),
                    region = table.Column<string>(type: "TEXT", nullable: false),
                    athenaAccessKey = table.Column<string>(type: "TEXT", nullable: false),
                    clusterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.id);
                    table.ForeignKey(
                        name: "FK_Devices_Clusters_clusterId",
                        column: x => x.clusterId,
                        principalTable: "Clusters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataEvents",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userId = table.Column<int>(type: "INTEGER", nullable: false),
                    ipAddress = table.Column<string>(type: "TEXT", nullable: false),
                    macAddress = table.Column<string>(type: "TEXT", nullable: false),
                    eventTimestamp = table.Column<string>(type: "TEXT", nullable: false),
                    eventType = table.Column<string>(type: "TEXT", nullable: false),
                    source = table.Column<string>(type: "TEXT", nullable: false),
                    severity = table.Column<string>(type: "TEXT", nullable: false),
                    location = table.Column<string>(type: "TEXT", nullable: false),
                    userAgent = table.Column<string>(type: "TEXT", nullable: false),
                    deviceBrand = table.Column<string>(type: "TEXT", nullable: false),
                    deviceModel = table.Column<string>(type: "TEXT", nullable: false),
                    osVersion = table.Column<string>(type: "TEXT", nullable: false),
                    appName = table.Column<string>(type: "TEXT", nullable: false),
                    appVersion = table.Column<string>(type: "TEXT", nullable: false),
                    errorCode = table.Column<int>(type: "INTEGER", nullable: false),
                    errorMessage = table.Column<string>(type: "TEXT", nullable: false),
                    responseTime = table.Column<int>(type: "INTEGER", nullable: false),
                    success = table.Column<bool>(type: "INTEGER", nullable: false),
                    deviceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEvents", x => x.id);
                    table.ForeignKey(
                        name: "FK_DataEvents_Devices_deviceId",
                        column: x => x.deviceId,
                        principalTable: "Devices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemoryMappings",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    memoryType = table.Column<string>(type: "TEXT", nullable: false),
                    memorySizeGb = table.Column<int>(type: "INTEGER", nullable: false),
                    memorySpeedMhz = table.Column<int>(type: "INTEGER", nullable: false),
                    memoryTechnology = table.Column<string>(type: "TEXT", nullable: false),
                    memoryLatency = table.Column<int>(type: "INTEGER", nullable: false),
                    memoryVoltage = table.Column<int>(type: "INTEGER", nullable: false),
                    memoryFormFacter = table.Column<string>(type: "TEXT", nullable: false),
                    memoryEccSupport = table.Column<bool>(type: "INTEGER", nullable: false),
                    memoryHeatSpreader = table.Column<bool>(type: "INTEGER", nullable: false),
                    memoryWarrantyYears = table.Column<int>(type: "INTEGER", nullable: false),
                    deviceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryMappings", x => x.id);
                    table.ForeignKey(
                        name: "FK_MemoryMappings_Devices_deviceId",
                        column: x => x.deviceId,
                        principalTable: "Devices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    memory = table.Column<string>(type: "TEXT", nullable: false),
                    family = table.Column<string>(type: "TEXT", nullable: false),
                    openFiles = table.Column<string>(type: "TEXT", nullable: false),
                    deviceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Processes_Devices_deviceId",
                        column: x => x.deviceId,
                        principalTable: "Devices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataEvents_deviceId",
                table: "DataEvents",
                column: "deviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_clusterId",
                table: "Devices",
                column: "clusterId");

            migrationBuilder.CreateIndex(
                name: "IX_MemoryMappings_deviceId",
                table: "MemoryMappings",
                column: "deviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_deviceId",
                table: "Processes",
                column: "deviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataEvents");

            migrationBuilder.DropTable(
                name: "MemoryMappings");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Clusters");
        }
    }
}
