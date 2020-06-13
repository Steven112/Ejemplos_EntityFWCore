using Microsoft.EntityFrameworkCore.Migrations;

namespace ETTFWC.Migrations
{
    public partial class spGetStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStudents]
                    @Nombre varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Students where Nombre like @Nombre +'%'
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
