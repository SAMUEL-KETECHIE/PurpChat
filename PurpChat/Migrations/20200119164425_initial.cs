using Microsoft.EntityFrameworkCore.Migrations;

namespace PurpChat.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ct.Chat_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ct.Message_ct.Chat_ChatId",
                table: "ct.Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ct.Message",
                table: "ct.Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ct.Chat",
                table: "ct.Chat");

            migrationBuilder.RenameTable(
                name: "ct.Message",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "ct.Chat",
                newName: "Chat");

            migrationBuilder.RenameIndex(
                name: "IX_ct.Message_ChatId",
                table: "Message",
                newName: "IX_Message_ChatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chat",
                table: "Chat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Chat_ChatId",
                table: "AspNetUsers",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Chat_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chat",
                table: "Chat");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "ct.Message");

            migrationBuilder.RenameTable(
                name: "Chat",
                newName: "ct.Chat");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ChatId",
                table: "ct.Message",
                newName: "IX_ct.Message_ChatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ct.Message",
                table: "ct.Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ct.Chat",
                table: "ct.Chat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ct.Chat_ChatId",
                table: "AspNetUsers",
                column: "ChatId",
                principalTable: "ct.Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ct.Message_ct.Chat_ChatId",
                table: "ct.Message",
                column: "ChatId",
                principalTable: "ct.Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
