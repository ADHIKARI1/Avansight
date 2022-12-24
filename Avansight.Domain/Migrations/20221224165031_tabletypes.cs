using Microsoft.EntityFrameworkCore.Migrations;

namespace Avansight.Domain.Migrations
{
    public partial class tabletypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TYPE [dbo].[PatientsTableType] AS TABLE(
							[PatientId] [int] NOT NULL,
							[Age] [int] NOT NULL,
							[Gender] [int] NOT NULL,
							[StudyId] [int] NOT NULL,
							[TreatmentCode] [nvarchar](450) NULL
						)
						GO
						CREATE TYPE [dbo].[StudiesTableType] AS TABLE(
							[StudyId] [int]  NOT NULL,
							[StudyIdentifier] [nvarchar](max) NULL,
							[StudyName] [nvarchar](max) NULL,
							[ProjectNumber] [nvarchar](max) NULL,
							[Type] [nvarchar](max) NULL
						)
						GO
						CREATE TYPE [dbo].[TreatmentGroupsTableType] AS TABLE(
							[TreatmentCode] [nvarchar](450) NOT NULL,
							[TreatmentName] [nvarchar](max) NULL,
							[TreatmentColor] [nvarchar](max) NULL
						)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
