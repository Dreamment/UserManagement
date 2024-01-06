using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class AddBasicAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("004e02be-e4b1-4142-a5e1-60beb04c4935"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("00763e57-9f60-4000-aba0-dd0ebd2ebc61"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0d18742c-8b4e-4827-8fbe-51be5fde36ac"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("251cf8fc-e856-42c1-a350-c750f903626a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2c000474-4756-4b8f-8f93-c54c6f920aab"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5a97f2a0-0f13-491b-8dfd-80137e0d52a5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7e418a92-a791-40c3-8d90-be19edab6534"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("817cff63-6991-4b18-88a0-9af9d19ecf8c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("95c235d2-802f-4bea-a1f7-a1d21d534501"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dc92bada-6f54-49ad-8244-76f7af5b9a06"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("1a19a1d2-bb42-47bd-baa4-16aae89bd01b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2791a504-0e21-4ca8-8017-9feb0b7c1737"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("522aa724-91e7-4ec7-8b9d-99cf601e4d75"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("536ec356-e3b6-4c13-88ae-69749efc13df"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5d809fbf-fe13-4b07-81b4-65cdf3aa25f8"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7a1c1f3f-77c7-480d-94b2-a0e816eebae2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9055fd5d-fdd9-4a77-a4aa-77526608c694"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9131144e-26f4-4929-b2a8-a6e34eba41c4"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("933520b7-4ca0-4964-889a-2e0d9a912957"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a041055c-1b55-4d38-bb0c-ff49fafe5940"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("17ef778c-7c4a-43ce-8d25-5ca8dcdc4c59"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("1f79d909-5e5f-4d3a-adc1-3f30ba1c525e"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("2713f4d8-332a-47c5-be9c-bd03f91b07d0"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("491874bb-3c68-42ba-9bc1-2f8cd0db616f"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("49882fb1-b7ac-421a-a5d4-f701c0a507fb"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("a020eb31-b11d-4559-9acb-6d10ac9118d0"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("a5cede74-8b08-42b7-b9ff-066f1912cbfa"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("b4304363-58e8-455c-9359-76e1e7d70271"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("d3cb7fe1-9635-4735-935b-cfcb28be72ae"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("da00e42a-ce87-46c1-86c2-6a51408f77de"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2398d6e8-c3d7-48a7-83cc-9a2fce6d4d5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 2, "31dec94b-13cd-4fbb-9637-ef8e3fa7d23e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "CompanyId", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { 11, 0, null, null, "b6c15a4c-75a2-457f-9251-4e6358e8a6eb", "admin@admin.com", false, 0, true, null, "admin", "ADMIN@ADMIN.com", "ADMIN", null, null, false, null, false, "admin", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "CatchPhrase", "Name" },
                values: new object[,]
                {
                    { new Guid("046680e9-6c16-4149-a339-b8a2fde1eec2"), "synergize scalable supply-chains", "Proactive didactic contingency", "Deckow-Crist" },
                    { new Guid("07873d71-da7b-4d9e-99a2-2a2662ed5d5f"), "generate enterprise e-tailers", "Configurable multimedia task-force", "Johns Group" },
                    { new Guid("4bd511ae-00f1-4c53-8b9d-f223d8e393a0"), "transition cutting-edge web services", "Multi-tiered zero tolerance productivity", "Robel-Corkery" },
                    { new Guid("869eb19c-aa3b-472b-be82-3cccb554ec85"), "aggregate real-time technologies", "Switchable contextually-based project", "Yost and Sons" },
                    { new Guid("89333afb-075b-4094-8ab1-10f99877c6e2"), "harness real-time e-markets", "Multi-layered client-server neural-net", "Romaguera-Crona" },
                    { new Guid("9f15e7e3-fefd-4706-b5f8-316ccbe952b5"), "target end-to-end models", "Centralized empowering task-force", "Hoeger LLC" },
                    { new Guid("da7c4462-2d01-42c3-8c85-8f0d6acf7a73"), "e-enable extensible e-tailers", "Implemented secondary concept", "Abernathy Group" },
                    { new Guid("e344396f-75f6-4ffe-b36b-94fc719a6ca2"), "revolutionize end-to-end systems", "User-centric fault-tolerant solution", "Keebler LLC" },
                    { new Guid("eb9c89de-69b2-4767-8d3f-5dd2ee13fd4c"), "e-enable innovative applications", "Synchronised bottom-line interface", "Considine-Lockman" },
                    { new Guid("f0c05cf2-6819-420f-862b-3c5c3145d5a7"), "e-enable strategic applications", "Face to face bifurcated interface", "Romaguera-Jacobson" }
                });

            migrationBuilder.InsertData(
                table: "Geos",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[,]
                {
                    { new Guid("058eca37-f115-4797-a805-406645e8ebf5"), "-71.4197", "71.7478" },
                    { new Guid("15cc4777-6975-47fa-b783-d37121ec3ad4"), "24.6463", "-168.8889" },
                    { new Guid("62619a2d-c87c-4116-94d7-4a69be339140"), "-37.3159", "81.1496" },
                    { new Guid("81a7794d-5ecd-43fd-9047-71c76c9d3853"), "29.4572", "-164.2990" },
                    { new Guid("974d65a1-d035-40c5-8819-5d66f3bebdf9"), "24.8918", "21.8984" },
                    { new Guid("d35a1943-1610-4f05-b325-af6959135756"), "-68.6102", "-47.0653" },
                    { new Guid("d57c2456-76da-43b6-aa6e-b26d7a8ccb4e"), "-43.9509", "-34.4618" },
                    { new Guid("ddcc3991-60cc-414a-b59e-35b9bf52ae69"), "-14.3990", "-120.7677" },
                    { new Guid("e09fab4d-5e93-45d1-a094-c4d622e79e64"), "-38.2386", "57.2232" },
                    { new Guid("ecd005bb-bd07-4807-bd31-43f2349bcd2c"), "-31.8129", "62.5342" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "GeoId", "Street", "Suite", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("0910c70a-b4aa-4a9c-8e28-b97485979d7f"), "Gwenborough", new Guid("62619a2d-c87c-4116-94d7-4a69be339140"), "Kulas Light", "Apt. 556", "92998-3874" },
                    { new Guid("0c99d7f3-6dc8-460b-9e05-3e1ec47b0929"), "McKenziehaven", new Guid("d35a1943-1610-4f05-b325-af6959135756"), "Douglas Extension", "Suite 847", "59590-4157" },
                    { new Guid("0f56720b-4881-460f-a788-78d864ad81c7"), "South Elvis", new Guid("81a7794d-5ecd-43fd-9047-71c76c9d3853"), "Hoeger Mall", "Apt. 692", "53919-4257" },
                    { new Guid("2be410ae-f384-497b-abb7-2437037d87b2"), "Lebsackbury", new Guid("e09fab4d-5e93-45d1-a094-c4d622e79e64"), "Kattie Turnpike", "Suite 198", "31428-2261" },
                    { new Guid("3718365a-687c-4f59-8762-c999d553c7f1"), "South Christy", new Guid("058eca37-f115-4797-a805-406645e8ebf5"), "Norberto Crossing", "Apt. 950", "23505-1337" },
                    { new Guid("4d4a24f5-d32b-42ec-a108-a54b3827ce10"), "Bartholomebury", new Guid("15cc4777-6975-47fa-b783-d37121ec3ad4"), "Dayna Park", "Suite 449", "76495-3109" },
                    { new Guid("774f09fc-9295-48ca-9618-dbc9d3421535"), "Roscoeview", new Guid("ecd005bb-bd07-4807-bd31-43f2349bcd2c"), "Skiles Walks", "Suite 351", "33263" },
                    { new Guid("9286aad9-1f37-4bbd-82aa-6ae9426e1fbe"), "Aliyaview", new Guid("ddcc3991-60cc-414a-b59e-35b9bf52ae69"), "Ellsworth Summit", "Suite 729", "45169" },
                    { new Guid("ab72f718-1ac6-46cc-8b70-ee415b2f3ad8"), "Howemouth", new Guid("974d65a1-d035-40c5-8819-5d66f3bebdf9"), "Rex Trail", "Suite 280", "58804-1099" },
                    { new Guid("b072743a-d394-4d88-875a-47e47c06ccf5"), "Wisokyburgh", new Guid("d57c2456-76da-43b6-aa6e-b26d7a8ccb4e"), "Victor Plains", "Suite 879", "90566-7771" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("0910c70a-b4aa-4a9c-8e28-b97485979d7f"), new Guid("89333afb-075b-4094-8ab1-10f99877c6e2"), "84de3806-8a45-4134-9777-bc744e64d12f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("b072743a-d394-4d88-875a-47e47c06ccf5"), new Guid("046680e9-6c16-4149-a339-b8a2fde1eec2"), "141e4750-7ad6-44c0-ab4f-28e3e8e3c58a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("0c99d7f3-6dc8-460b-9e05-3e1ec47b0929"), new Guid("f0c05cf2-6819-420f-862b-3c5c3145d5a7"), "14352a75-87b2-4ce3-9c55-921ba14cf1c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("0f56720b-4881-460f-a788-78d864ad81c7"), new Guid("4bd511ae-00f1-4c53-8b9d-f223d8e393a0"), "d1faa3f7-86fa-4296-a09b-f8213776169a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("774f09fc-9295-48ca-9618-dbc9d3421535"), new Guid("e344396f-75f6-4ffe-b36b-94fc719a6ca2"), "e14c0915-2b5e-4fac-866f-d0b9239c6289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("3718365a-687c-4f59-8762-c999d553c7f1"), new Guid("eb9c89de-69b2-4767-8d3f-5dd2ee13fd4c"), "c304e2dd-8aa0-499b-86e6-380302d14d4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("ab72f718-1ac6-46cc-8b70-ee415b2f3ad8"), new Guid("07873d71-da7b-4d9e-99a2-2a2662ed5d5f"), "bf94e500-9fb2-4663-b891-3d13a2b9da43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("9286aad9-1f37-4bbd-82aa-6ae9426e1fbe"), new Guid("da7c4462-2d01-42c3-8c85-8f0d6acf7a73"), "adc8fa9d-1451-4d8f-b12b-189078f29e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("4d4a24f5-d32b-42ec-a108-a54b3827ce10"), new Guid("869eb19c-aa3b-472b-be82-3cccb554ec85"), "bb78fe16-ab4c-48f9-84a7-bd16d25c9851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("2be410ae-f384-497b-abb7-2437037d87b2"), new Guid("9f15e7e3-fefd-4706-b5f8-316ccbe952b5"), "2fde00bf-4aa6-444f-bbc6-0d48a9bc9240" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0910c70a-b4aa-4a9c-8e28-b97485979d7f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0c99d7f3-6dc8-460b-9e05-3e1ec47b0929"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0f56720b-4881-460f-a788-78d864ad81c7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2be410ae-f384-497b-abb7-2437037d87b2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3718365a-687c-4f59-8762-c999d553c7f1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4d4a24f5-d32b-42ec-a108-a54b3827ce10"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("774f09fc-9295-48ca-9618-dbc9d3421535"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9286aad9-1f37-4bbd-82aa-6ae9426e1fbe"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ab72f718-1ac6-46cc-8b70-ee415b2f3ad8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b072743a-d394-4d88-875a-47e47c06ccf5"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("046680e9-6c16-4149-a339-b8a2fde1eec2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("07873d71-da7b-4d9e-99a2-2a2662ed5d5f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4bd511ae-00f1-4c53-8b9d-f223d8e393a0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("869eb19c-aa3b-472b-be82-3cccb554ec85"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("89333afb-075b-4094-8ab1-10f99877c6e2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9f15e7e3-fefd-4706-b5f8-316ccbe952b5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("da7c4462-2d01-42c3-8c85-8f0d6acf7a73"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("e344396f-75f6-4ffe-b36b-94fc719a6ca2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("eb9c89de-69b2-4767-8d3f-5dd2ee13fd4c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f0c05cf2-6819-420f-862b-3c5c3145d5a7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("058eca37-f115-4797-a805-406645e8ebf5"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("15cc4777-6975-47fa-b783-d37121ec3ad4"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("62619a2d-c87c-4116-94d7-4a69be339140"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("81a7794d-5ecd-43fd-9047-71c76c9d3853"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("974d65a1-d035-40c5-8819-5d66f3bebdf9"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("d35a1943-1610-4f05-b325-af6959135756"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("d57c2456-76da-43b6-aa6e-b26d7a8ccb4e"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("ddcc3991-60cc-414a-b59e-35b9bf52ae69"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("e09fab4d-5e93-45d1-a094-c4d622e79e64"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("ecd005bb-bd07-4807-bd31-43f2349bcd2c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "67f5556e-7b96-4d78-b4a0-a75dbe9554a0");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "CatchPhrase", "Name" },
                values: new object[,]
                {
                    { new Guid("1a19a1d2-bb42-47bd-baa4-16aae89bd01b"), "revolutionize end-to-end systems", "User-centric fault-tolerant solution", "Keebler LLC" },
                    { new Guid("2791a504-0e21-4ca8-8017-9feb0b7c1737"), "aggregate real-time technologies", "Switchable contextually-based project", "Yost and Sons" },
                    { new Guid("522aa724-91e7-4ec7-8b9d-99cf601e4d75"), "generate enterprise e-tailers", "Configurable multimedia task-force", "Johns Group" },
                    { new Guid("536ec356-e3b6-4c13-88ae-69749efc13df"), "e-enable innovative applications", "Synchronised bottom-line interface", "Considine-Lockman" },
                    { new Guid("5d809fbf-fe13-4b07-81b4-65cdf3aa25f8"), "e-enable extensible e-tailers", "Implemented secondary concept", "Abernathy Group" },
                    { new Guid("7a1c1f3f-77c7-480d-94b2-a0e816eebae2"), "target end-to-end models", "Centralized empowering task-force", "Hoeger LLC" },
                    { new Guid("9055fd5d-fdd9-4a77-a4aa-77526608c694"), "harness real-time e-markets", "Multi-layered client-server neural-net", "Romaguera-Crona" },
                    { new Guid("9131144e-26f4-4929-b2a8-a6e34eba41c4"), "e-enable strategic applications", "Face to face bifurcated interface", "Romaguera-Jacobson" },
                    { new Guid("933520b7-4ca0-4964-889a-2e0d9a912957"), "synergize scalable supply-chains", "Proactive didactic contingency", "Deckow-Crist" },
                    { new Guid("a041055c-1b55-4d38-bb0c-ff49fafe5940"), "transition cutting-edge web services", "Multi-tiered zero tolerance productivity", "Robel-Corkery" }
                });

            migrationBuilder.InsertData(
                table: "Geos",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[,]
                {
                    { new Guid("17ef778c-7c4a-43ce-8d25-5ca8dcdc4c59"), "-43.9509", "-34.4618" },
                    { new Guid("1f79d909-5e5f-4d3a-adc1-3f30ba1c525e"), "-37.3159", "81.1496" },
                    { new Guid("2713f4d8-332a-47c5-be9c-bd03f91b07d0"), "-68.6102", "-47.0653" },
                    { new Guid("491874bb-3c68-42ba-9bc1-2f8cd0db616f"), "24.8918", "21.8984" },
                    { new Guid("49882fb1-b7ac-421a-a5d4-f701c0a507fb"), "24.6463", "-168.8889" },
                    { new Guid("a020eb31-b11d-4559-9acb-6d10ac9118d0"), "29.4572", "-164.2990" },
                    { new Guid("a5cede74-8b08-42b7-b9ff-066f1912cbfa"), "-71.4197", "71.7478" },
                    { new Guid("b4304363-58e8-455c-9359-76e1e7d70271"), "-14.3990", "-120.7677" },
                    { new Guid("d3cb7fe1-9635-4735-935b-cfcb28be72ae"), "-38.2386", "57.2232" },
                    { new Guid("da00e42a-ce87-46c1-86c2-6a51408f77de"), "-31.8129", "62.5342" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "GeoId", "Street", "Suite", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("004e02be-e4b1-4142-a5e1-60beb04c4935"), "Gwenborough", new Guid("1f79d909-5e5f-4d3a-adc1-3f30ba1c525e"), "Kulas Light", "Apt. 556", "92998-3874" },
                    { new Guid("00763e57-9f60-4000-aba0-dd0ebd2ebc61"), "Lebsackbury", new Guid("d3cb7fe1-9635-4735-935b-cfcb28be72ae"), "Kattie Turnpike", "Suite 198", "31428-2261" },
                    { new Guid("0d18742c-8b4e-4827-8fbe-51be5fde36ac"), "South Christy", new Guid("a5cede74-8b08-42b7-b9ff-066f1912cbfa"), "Norberto Crossing", "Apt. 950", "23505-1337" },
                    { new Guid("251cf8fc-e856-42c1-a350-c750f903626a"), "Wisokyburgh", new Guid("17ef778c-7c4a-43ce-8d25-5ca8dcdc4c59"), "Victor Plains", "Suite 879", "90566-7771" },
                    { new Guid("2c000474-4756-4b8f-8f93-c54c6f920aab"), "South Elvis", new Guid("a020eb31-b11d-4559-9acb-6d10ac9118d0"), "Hoeger Mall", "Apt. 692", "53919-4257" },
                    { new Guid("5a97f2a0-0f13-491b-8dfd-80137e0d52a5"), "McKenziehaven", new Guid("2713f4d8-332a-47c5-be9c-bd03f91b07d0"), "Douglas Extension", "Suite 847", "59590-4157" },
                    { new Guid("7e418a92-a791-40c3-8d90-be19edab6534"), "Howemouth", new Guid("491874bb-3c68-42ba-9bc1-2f8cd0db616f"), "Rex Trail", "Suite 280", "58804-1099" },
                    { new Guid("817cff63-6991-4b18-88a0-9af9d19ecf8c"), "Roscoeview", new Guid("da00e42a-ce87-46c1-86c2-6a51408f77de"), "Skiles Walks", "Suite 351", "33263" },
                    { new Guid("95c235d2-802f-4bea-a1f7-a1d21d534501"), "Aliyaview", new Guid("b4304363-58e8-455c-9359-76e1e7d70271"), "Ellsworth Summit", "Suite 729", "45169" },
                    { new Guid("dc92bada-6f54-49ad-8244-76f7af5b9a06"), "Bartholomebury", new Guid("49882fb1-b7ac-421a-a5d4-f701c0a507fb"), "Dayna Park", "Suite 449", "76495-3109" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("004e02be-e4b1-4142-a5e1-60beb04c4935"), new Guid("9055fd5d-fdd9-4a77-a4aa-77526608c694"), "d200efea-4689-481f-8804-d7e0ac7f7ab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("251cf8fc-e856-42c1-a350-c750f903626a"), new Guid("933520b7-4ca0-4964-889a-2e0d9a912957"), "e52589af-7125-4094-a5f4-ffffd82e9947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("5a97f2a0-0f13-491b-8dfd-80137e0d52a5"), new Guid("9131144e-26f4-4929-b2a8-a6e34eba41c4"), "260b01b7-04f6-4e8b-ac44-e80ef04dc619" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("2c000474-4756-4b8f-8f93-c54c6f920aab"), new Guid("a041055c-1b55-4d38-bb0c-ff49fafe5940"), "82e84250-11be-4a5b-b8ee-0001fc0608e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("817cff63-6991-4b18-88a0-9af9d19ecf8c"), new Guid("1a19a1d2-bb42-47bd-baa4-16aae89bd01b"), "7e65fc53-b5ac-4839-bfe4-fabf4762c1b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("0d18742c-8b4e-4827-8fbe-51be5fde36ac"), new Guid("536ec356-e3b6-4c13-88ae-69749efc13df"), "60d887b7-ba16-4913-8b31-4e97a9221d87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("7e418a92-a791-40c3-8d90-be19edab6534"), new Guid("522aa724-91e7-4ec7-8b9d-99cf601e4d75"), "eb9528d2-1440-4869-ac8f-5f3acc1dbc53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("95c235d2-802f-4bea-a1f7-a1d21d534501"), new Guid("5d809fbf-fe13-4b07-81b4-65cdf3aa25f8"), "68e93e5f-5200-41c6-840c-df09acf96efd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("dc92bada-6f54-49ad-8244-76f7af5b9a06"), new Guid("2791a504-0e21-4ca8-8017-9feb0b7c1737"), "32f137c7-bc5d-4a46-859f-6b60e7e311f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("00763e57-9f60-4000-aba0-dd0ebd2ebc61"), new Guid("7a1c1f3f-77c7-480d-94b2-a0e816eebae2"), "3d245b7f-0201-4894-9cfb-458de55286c5" });
        }
    }
}
