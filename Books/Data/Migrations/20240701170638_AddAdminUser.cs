using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;


#nullable disable

namespace Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        const string ADMIN_USER_GUID = "0fe22d47-7c57-46d4-8352-a24d0fa55591";
        const string ADMIN_ROLE_GUID = "1f67a96b-9a5c-4279-9f22-3e16dd51956b";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var adminUser = new IdentityUser
            {
                Id = ADMIN_USER_GUID,
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                AccessFailedCount = 0,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                ConcurrencyStamp = Guid.NewGuid().ToString("D")
            };

            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Password12345");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "AccessFailedCount", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "ConcurrencyStamp" },
                values: new object[] { adminUser.Id, adminUser.UserName, adminUser.NormalizedUserName, adminUser.Email, adminUser.NormalizedEmail, adminUser.EmailConfirmed, adminUser.PasswordHash, adminUser.SecurityStamp, adminUser.AccessFailedCount, adminUser.PhoneNumberConfirmed, adminUser.TwoFactorEnabled, adminUser.LockoutEnabled, adminUser.ConcurrencyStamp }
            );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { ADMIN_ROLE_GUID, "Admin", "ADMIN", Guid.NewGuid().ToString("D") }
            );

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { ADMIN_USER_GUID, ADMIN_ROLE_GUID }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { ADMIN_USER_GUID, ADMIN_ROLE_GUID }
            );

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: ADMIN_USER_GUID
            );

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: ADMIN_ROLE_GUID
            );
        }
    }
}
