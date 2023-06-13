using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDesk.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TransportDetails",
                newName: "TransportDetailId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HotelDetails",
                newName: "HotelDetailId");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Documents",
                newName: "CommentName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documents",
                newName: "DocumentsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CommonTypes",
                newName: "CommonTypeRefId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TransportDetailId",
                table: "TransportDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HotelDetailId",
                table: "HotelDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentName",
                table: "Documents",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "DocumentsId",
                table: "Documents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommonTypeRefId",
                table: "CommonTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
