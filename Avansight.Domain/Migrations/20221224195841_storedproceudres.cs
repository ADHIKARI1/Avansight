using Microsoft.EntityFrameworkCore.Migrations;

namespace Avansight.Domain.Migrations
{
    public partial class storedproceudres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE [dbo].[StudyImport]	
									@Study AS StudiesTableType READONLY,
									@TreatmentGroups AS TreatmentGroupsTableType READONLY
								AS
								BEGIN	
									INSERT INTO Studies(StudyIdentifier, StudyName, ProjectNumber, Type)
									SELECT StudyIdentifier, StudyName, ProjectNumber, Type FROM @Study;
									INSERT INTO TreatmentGroups(TreatmentName, TreatmentColor)
									SELECT TreatmentName, TreatmentColor FROM @TreatmentGroups;
								END
								GO
								CREATE PROCEDURE [dbo].[PatientSet]
									@Patients AS PatientsTableType READONLY
								AS
								BEGIN
									INSERT INTO Patients(Age,Gender, StudyId, TreatmentCode)   
									SELECT Age,Gender, StudyId, TreatmentCode from @Patients;	
								END
								GO
								CREATE TRIGGER  Trigger_Patients_ForInsertmagic 
								ON Patients  
								FOR INSERT  
								AS  
								begin  
								SELECT * FROM INSERTED
								end 
								GO
								CREATE PROCEDURE [dbo].[PatientGet]
								(
									@StudyId BIGINT,
									@TreatmentCode NVARCHAR(MAX) = Null,
									@Age NVARCHAR(MAX) = Null,
									@Gender BIGINT = Null    
								)AS
								BEGIN
									SELECT *
									FROM Patients
									WHERE StudyId = @StudyId OR TreatmentCode LIKE '%'+@TreatmentCode+'%' OR Age LIKE '%'+@Age+'%' OR Gender = @Gender;
								END
								GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
