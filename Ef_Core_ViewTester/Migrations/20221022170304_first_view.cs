using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Core_ViewTester.Migrations
{
    public partial class first_view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW dbo.ItemReadModels 
                                   AS 
                                   SELECT item.Id, item.Name, idesc.Description
                                   FROM Items item
                                   JOIN ItemDescriptions idesc ON idesc.ItemId = item.Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.ItemReadModels");
        }
    }
}
