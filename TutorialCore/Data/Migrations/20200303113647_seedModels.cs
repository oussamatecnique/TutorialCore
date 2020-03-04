using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorialCore.Data.Migrations
{
    public partial class seedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('ModelA',7)");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Model2',7)");

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Model3',8)");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Model4',8)");

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Model5',9)");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Model6',9)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
