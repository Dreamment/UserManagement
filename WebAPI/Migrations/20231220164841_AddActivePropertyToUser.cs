using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class AddActivePropertyToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("16531efc-d321-4ac1-b99a-227d515ceec9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2234f5f8-cfac-4b55-9618-d3762c2a3e08"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2589074a-33bc-48f2-81db-a5628ce64a84"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6f609d2b-9a33-4639-8868-f256ca902f4c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a41e78b4-b41a-44ff-bd2b-8091c4cb5087"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bde87c73-f5a3-4734-bc35-e0729829dea8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c1ae2ce8-f2d4-4390-95d5-f3ddfb8b6938"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c49425a5-f1e5-49f1-a192-384a9c2264a1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d24276be-d4fb-43b2-89e5-ffe158402430"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eb342bb0-5503-4efe-a932-f8a7639c737a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("157834d1-ce68-425b-95e8-e66721eeafa6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("3b5401cb-8b0d-4fc2-92c1-020661ab2937"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("55a1bb83-4afc-46c2-b0ec-ff0e54662f3c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5a74e90b-f29c-41e8-a1fe-5ae32a315fdc"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("71f929d8-8710-4d96-a07b-b2b11d1e3659"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("74b4b940-fc62-4aa7-9ca6-9f5f19b4309d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7aea4ff5-2dcb-4f6b-90af-42c6cc04d4bc"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("da8d0761-1ac8-4a48-9c97-b5e51ac07638"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("edca34c9-f180-4e41-8960-201a6b027c95"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ef55ba32-b66d-42c3-888d-3e4c42f37d33"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("1d98acc8-31bf-44c8-b68d-b3624a42816d"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("24c2bd36-d059-4dff-baa6-b0272a52bba9"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("33acbb2f-875f-495f-a211-326bda5a08d8"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("4098128c-9973-49e0-963a-35dc3a047772"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("78d89c6e-a455-4242-a52b-ca7f24beca7b"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("80e6edb4-fd1b-4353-875e-d4a93f9aa8aa"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("a39fc932-a76f-4a88-acda-e825505f3040"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("b9959fc2-6c24-4452-a1b7-31abe21f74e0"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("e4aafd82-92df-4e95-b3db-88905c650434"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("f9d1569c-8ced-4a2b-be95-20988b6ee218"));

            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "67f5556e-7b96-4d78-b4a0-a75dbe9554a0", "USER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "dab55e26-8f87-47fa-b1d8-72e18ec55503", "User" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "CatchPhrase", "Name" },
                values: new object[,]
                {
                    { new Guid("157834d1-ce68-425b-95e8-e66721eeafa6"), "e-enable innovative applications", "Synchronised bottom-line interface", "Considine-Lockman" },
                    { new Guid("3b5401cb-8b0d-4fc2-92c1-020661ab2937"), "synergize scalable supply-chains", "Proactive didactic contingency", "Deckow-Crist" },
                    { new Guid("55a1bb83-4afc-46c2-b0ec-ff0e54662f3c"), "target end-to-end models", "Centralized empowering task-force", "Hoeger LLC" },
                    { new Guid("5a74e90b-f29c-41e8-a1fe-5ae32a315fdc"), "aggregate real-time technologies", "Switchable contextually-based project", "Yost and Sons" },
                    { new Guid("71f929d8-8710-4d96-a07b-b2b11d1e3659"), "e-enable extensible e-tailers", "Implemented secondary concept", "Abernathy Group" },
                    { new Guid("74b4b940-fc62-4aa7-9ca6-9f5f19b4309d"), "transition cutting-edge web services", "Multi-tiered zero tolerance productivity", "Robel-Corkery" },
                    { new Guid("7aea4ff5-2dcb-4f6b-90af-42c6cc04d4bc"), "e-enable strategic applications", "Face to face bifurcated interface", "Romaguera-Jacobson" },
                    { new Guid("da8d0761-1ac8-4a48-9c97-b5e51ac07638"), "generate enterprise e-tailers", "Configurable multimedia task-force", "Johns Group" },
                    { new Guid("edca34c9-f180-4e41-8960-201a6b027c95"), "harness real-time e-markets", "Multi-layered client-server neural-net", "Romaguera-Crona" },
                    { new Guid("ef55ba32-b66d-42c3-888d-3e4c42f37d33"), "revolutionize end-to-end systems", "User-centric fault-tolerant solution", "Keebler LLC" }
                });

            migrationBuilder.InsertData(
                table: "Geos",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[,]
                {
                    { new Guid("1d98acc8-31bf-44c8-b68d-b3624a42816d"), "-31.8129", "62.5342" },
                    { new Guid("24c2bd36-d059-4dff-baa6-b0272a52bba9"), "-43.9509", "-34.4618" },
                    { new Guid("33acbb2f-875f-495f-a211-326bda5a08d8"), "29.4572", "-164.2990" },
                    { new Guid("4098128c-9973-49e0-963a-35dc3a047772"), "-14.3990", "-120.7677" },
                    { new Guid("78d89c6e-a455-4242-a52b-ca7f24beca7b"), "24.8918", "21.8984" },
                    { new Guid("80e6edb4-fd1b-4353-875e-d4a93f9aa8aa"), "-37.3159", "81.1496" },
                    { new Guid("a39fc932-a76f-4a88-acda-e825505f3040"), "-71.4197", "71.7478" },
                    { new Guid("b9959fc2-6c24-4452-a1b7-31abe21f74e0"), "-68.6102", "-47.0653" },
                    { new Guid("e4aafd82-92df-4e95-b3db-88905c650434"), "24.6463", "-168.8889" },
                    { new Guid("f9d1569c-8ced-4a2b-be95-20988b6ee218"), "-38.2386", "57.2232" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "GeoId", "Street", "Suite", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("16531efc-d321-4ac1-b99a-227d515ceec9"), "Howemouth", new Guid("78d89c6e-a455-4242-a52b-ca7f24beca7b"), "Rex Trail", "Suite 280", "58804-1099" },
                    { new Guid("2234f5f8-cfac-4b55-9618-d3762c2a3e08"), "Wisokyburgh", new Guid("24c2bd36-d059-4dff-baa6-b0272a52bba9"), "Victor Plains", "Suite 879", "90566-7771" },
                    { new Guid("2589074a-33bc-48f2-81db-a5628ce64a84"), "Roscoeview", new Guid("1d98acc8-31bf-44c8-b68d-b3624a42816d"), "Skiles Walks", "Suite 351", "33263" },
                    { new Guid("6f609d2b-9a33-4639-8868-f256ca902f4c"), "Bartholomebury", new Guid("e4aafd82-92df-4e95-b3db-88905c650434"), "Dayna Park", "Suite 449", "76495-3109" },
                    { new Guid("a41e78b4-b41a-44ff-bd2b-8091c4cb5087"), "McKenziehaven", new Guid("b9959fc2-6c24-4452-a1b7-31abe21f74e0"), "Douglas Extension", "Suite 847", "59590-4157" },
                    { new Guid("bde87c73-f5a3-4734-bc35-e0729829dea8"), "Lebsackbury", new Guid("f9d1569c-8ced-4a2b-be95-20988b6ee218"), "Kattie Turnpike", "Suite 198", "31428-2261" },
                    { new Guid("c1ae2ce8-f2d4-4390-95d5-f3ddfb8b6938"), "Gwenborough", new Guid("80e6edb4-fd1b-4353-875e-d4a93f9aa8aa"), "Kulas Light", "Apt. 556", "92998-3874" },
                    { new Guid("c49425a5-f1e5-49f1-a192-384a9c2264a1"), "Aliyaview", new Guid("4098128c-9973-49e0-963a-35dc3a047772"), "Ellsworth Summit", "Suite 729", "45169" },
                    { new Guid("d24276be-d4fb-43b2-89e5-ffe158402430"), "South Christy", new Guid("a39fc932-a76f-4a88-acda-e825505f3040"), "Norberto Crossing", "Apt. 950", "23505-1337" },
                    { new Guid("eb342bb0-5503-4efe-a932-f8a7639c737a"), "South Elvis", new Guid("33acbb2f-875f-495f-a211-326bda5a08d8"), "Hoeger Mall", "Apt. 692", "53919-4257" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("c1ae2ce8-f2d4-4390-95d5-f3ddfb8b6938"), new Guid("edca34c9-f180-4e41-8960-201a6b027c95"), "1556a952-bcb2-4cfb-b40f-6a17b81ee319" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("2234f5f8-cfac-4b55-9618-d3762c2a3e08"), new Guid("3b5401cb-8b0d-4fc2-92c1-020661ab2937"), "3bd0e8de-56c8-45df-addb-feeb6e8cc8a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("a41e78b4-b41a-44ff-bd2b-8091c4cb5087"), new Guid("7aea4ff5-2dcb-4f6b-90af-42c6cc04d4bc"), "b059469c-e2e6-412b-814e-704c72804a13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("eb342bb0-5503-4efe-a932-f8a7639c737a"), new Guid("74b4b940-fc62-4aa7-9ca6-9f5f19b4309d"), "1b2da2eb-959d-4726-a2c6-6ce8f09e6cda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("2589074a-33bc-48f2-81db-a5628ce64a84"), new Guid("ef55ba32-b66d-42c3-888d-3e4c42f37d33"), "43c396e4-3b7f-454b-857d-618301ed7fb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("d24276be-d4fb-43b2-89e5-ffe158402430"), new Guid("157834d1-ce68-425b-95e8-e66721eeafa6"), "fd0a0bb6-3172-46c6-a76f-12399e2c6334" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("16531efc-d321-4ac1-b99a-227d515ceec9"), new Guid("da8d0761-1ac8-4a48-9c97-b5e51ac07638"), "8d7b8c9c-3870-4340-9229-b1865b89f2f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("c49425a5-f1e5-49f1-a192-384a9c2264a1"), new Guid("71f929d8-8710-4d96-a07b-b2b11d1e3659"), "bc9f2952-3659-41b4-bf7c-801dbc403292" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("6f609d2b-9a33-4639-8868-f256ca902f4c"), new Guid("5a74e90b-f29c-41e8-a1fe-5ae32a315fdc"), "16ef5131-be98-43ee-b77d-32c0775b139d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("bde87c73-f5a3-4734-bc35-e0729829dea8"), new Guid("55a1bb83-4afc-46c2-b0ec-ff0e54662f3c"), "dbed9222-4cee-4c34-abf2-e265a62eba63" });
        }
    }
}
