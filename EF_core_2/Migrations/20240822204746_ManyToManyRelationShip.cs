using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_2.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dep_idId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Ins_id",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "stud_Id",
                table: "Stud_Courses",
                newName: "Stud_Id");

            migrationBuilder.RenameColumn(
                name: "Dep_idId",
                table: "Instructors",
                newName: "Dept_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dep_idId",
                table: "Instructors",
                newName: "IX_Instructors_Dept_ID");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Courses",
                newName: "Instructor_ID");

            migrationBuilder.RenameColumn(
                name: "evaluation",
                table: "Course_insts",
                newName: "Evaluation");

            migrationBuilder.RenameColumn(
                name: "ins_ID",
                table: "Course_insts",
                newName: "Ins_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Evaluation",
                table: "Course_insts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Topic_Id",
                table: "Courses",
                column: "Topic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_insts_Course_ID",
                table: "Course_insts",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_insts_Courses_Course_ID",
                table: "Course_insts",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_insts_Instructors_Ins_ID",
                table: "Course_insts",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Topic_Id",
                table: "Courses",
                column: "Topic_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_insts_Courses_Course_ID",
                table: "Course_insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_insts_Instructors_Ins_ID",
                table: "Course_insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Topic_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Topic_Id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_insts_Course_ID",
                table: "Course_insts");

            migrationBuilder.RenameColumn(
                name: "Stud_Id",
                table: "Stud_Courses",
                newName: "stud_Id");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Instructors",
                newName: "Dep_idId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                newName: "IX_Instructors_Dep_idId");

            migrationBuilder.RenameColumn(
                name: "Instructor_ID",
                table: "Courses",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "Evaluation",
                table: "Course_insts",
                newName: "evaluation");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Course_insts",
                newName: "ins_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evaluation",
                table: "Course_insts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dep_idId",
                table: "Instructors",
                column: "Dep_idId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
