using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Database.SqlServer.Migrations
{
    public partial class SeedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO FEATURES (Name) VALUES ('Feature1')");
            migrationBuilder.Sql("INSERT INTO FEATURES (Name) VALUES ('Feature2')");
            migrationBuilder.Sql("INSERT INTO FEATURES (Name) VALUES ('Feature3')");
            migrationBuilder.Sql("INSERT INTO FEATURES (Name) VALUES ('Feature4')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FEATURES WHERE Name = 'Feature1'");
            migrationBuilder.Sql("DELETE FROM FEATURES WHERE Name = 'Feature2'");
            migrationBuilder.Sql("DELETE FROM FEATURES WHERE Name = 'Feature3'");
            migrationBuilder.Sql("DELETE FROM FEATURES WHERE Name = 'Feature4'");
        }
    }
}
