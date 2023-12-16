using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "CatchPhrase", "Name" },
                values: new object[,]
                {
                    { new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"), "target end-to-end models", "Centralized empowering task-force", "Hoeger LLC" },
                    { new Guid("55882d84-c9e3-4c3d-930f-c06534133169"), "aggregate real-time technologies", "Switchable contextually-based project", "Yost and Sons" },
                    { new Guid("64615c87-7528-4c65-b025-4778e687d32f"), "e-enable extensible e-tailers", "Implemented secondary concept", "Abernathy Group" },
                    { new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"), "transition cutting-edge web services", "Multi-tiered zero tolerance productivity", "Robel-Corkery" },
                    { new Guid("6867e142-0989-473c-a891-f050afe3abff"), "generate enterprise e-tailers", "Configurable multimedia task-force", "Johns Group" },
                    { new Guid("8299272d-0423-447a-845b-5d5488e83f58"), "harness real-time e-markets", "Multi-layered client-server neural-net", "Romaguera-Crona" },
                    { new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"), "e-enable strategic applications", "Face to face bifurcated interface", "Romaguera-Jacobson" },
                    { new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"), "revolutionize end-to-end systems", "User-centric fault-tolerant solution", "Keebler LLC" },
                    { new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"), "synergize scalable supply-chains", "Proactive didactic contingency", "Deckow-Crist" },
                    { new Guid("e635145b-c656-4861-8cea-9f8b45282190"), "e-enable innovative applications", "Synchronised bottom-line interface", "Considine-Lockman" }
                });

            migrationBuilder.InsertData(
                table: "Geos",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[,]
                {
                    { new Guid("58d2e5ee-1f5c-4d5b-9f99-1d052e035772"), "-14.3990", "-120.7677" },
                    { new Guid("6f15bb28-bba0-4251-9836-1875b8af33c8"), "-68.6102", "-47.0653" },
                    { new Guid("700ab7ec-42db-4bd5-b7a8-d97e5412f426"), "-43.9509", "-34.4618" },
                    { new Guid("75f521d8-0da0-46fb-9586-67750d5feee1"), "-37.3159", "81.1496" },
                    { new Guid("8ccb69ab-612e-441f-9124-44215b2d7e33"), "-71.4197", "71.7478" },
                    { new Guid("98f6ddbf-c560-48bc-9ac7-10ece81b7821"), "-38.2386", "57.2232" },
                    { new Guid("a11a4dfb-3916-46c3-a245-73ce896cceba"), "-31.8129", "62.5342" },
                    { new Guid("b017c6c3-8717-4a59-a8fe-b9935251fb6a"), "29.4572", "-164.2990" },
                    { new Guid("d62481e7-d381-4f3e-b739-3a0a095ea01d"), "24.8918", "21.8984" },
                    { new Guid("ea06a4d5-c2cd-4504-8fe9-066d79c18664"), "24.6463", "-168.8889" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "GeoId", "Street", "Suite", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"), "Wisokyburgh", new Guid("700ab7ec-42db-4bd5-b7a8-d97e5412f426"), "Victor Plains", "Suite 879", "90566-7771" },
                    { new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"), "South Christy", new Guid("8ccb69ab-612e-441f-9124-44215b2d7e33"), "Norberto Crossing", "Apt. 950", "23505-1337" },
                    { new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"), "Gwenborough", new Guid("75f521d8-0da0-46fb-9586-67750d5feee1"), "Kulas Light", "Apt. 556", "92998-3874" },
                    { new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"), "McKenziehaven", new Guid("6f15bb28-bba0-4251-9836-1875b8af33c8"), "Douglas Extension", "Suite 847", "59590-4157" },
                    { new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"), "Roscoeview", new Guid("a11a4dfb-3916-46c3-a245-73ce896cceba"), "Skiles Walks", "Suite 351", "33263" },
                    { new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"), "Aliyaview", new Guid("58d2e5ee-1f5c-4d5b-9f99-1d052e035772"), "Ellsworth Summit", "Suite 729", "45169" },
                    { new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"), "Lebsackbury", new Guid("98f6ddbf-c560-48bc-9ac7-10ece81b7821"), "Kattie Turnpike", "Suite 198", "31428-2261" },
                    { new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"), "Howemouth", new Guid("d62481e7-d381-4f3e-b739-3a0a095ea01d"), "Rex Trail", "Suite 280", "58804-1099" },
                    { new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"), "Bartholomebury", new Guid("ea06a4d5-c2cd-4504-8fe9-066d79c18664"), "Dayna Park", "Suite 449", "76495-3109" },
                    { new Guid("f335b711-b806-4be6-a3c7-dbd857383457"), "South Elvis", new Guid("b017c6c3-8717-4a59-a8fe-b9935251fb6a"), "Hoeger Mall", "Apt. 692", "53919-4257" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "CompanyId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[,]
                {
                    { 1, 0, new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"), new Guid("8299272d-0423-447a-845b-5d5488e83f58"), "e83cd856-befd-4f51-84bf-93e03c504c3b", "Sincere@april.biz", false, true, null, "Leanne Graham", "SINCERE@APRIL.BIZ", "BRET", null, "1-770-736-8031 x56442", false, null, false, "Bret", "hildegard.org" },
                    { 2, 0, new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"), new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"), "71d948a8-5dc3-4cd5-8edc-c0fb46273a29", "Shanna@melissa.tv", false, true, null, "Ervin Howell", "SHANNA@MELISSA.TV", "ANTONETTE", null, "010-692-6593 x09125", false, null, false, "Antonette", "anastasia.net" },
                    { 3, 0, new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"), new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"), "40f1a05c-aaf0-4726-b731-c4af388cd4af", "Nathan@yesenia.net", false, true, null, "Clementine Bauch", "NATHAN@YESENIA.NET", "SAMANTHA", null, "1-463-123-4447", false, null, false, "Samantha", "ramiro.info" },
                    { 4, 0, new Guid("f335b711-b806-4be6-a3c7-dbd857383457"), new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"), "b95c6f60-07e0-4bc9-9ca7-7c691e629522", "Julianne.OConner@kory.org", false, true, null, "Patricia Lebsack", "JULIANNE.OCONNER@KORY.ORG", "KARIANNE", null, "493-170-9623 x156", false, null, false, "Karianne", "kale.biz" },
                    { 5, 0, new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"), new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"), "01e7146b-bb1f-4a9b-98c0-53aa3e6b4c6f", "Lucio_Hettinger@annie.ca", false, true, null, "Chelsey Dietrich", "LUCIO_HETTINGER@ANNIE.CA", "KAMREN", null, "(254)954-1289", false, null, false, "Kamren", "demarco.info" },
                    { 6, 0, new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"), new Guid("e635145b-c656-4861-8cea-9f8b45282190"), "7a1ab073-9da7-434c-9aa8-71fbbff13a00", "Karley_Dach@jasper.info", false, true, null, "Mrs. Dennis Schulist", "KARLEY_DACH@JASPER.INFO", "LEOPOLDO_CORKERY", null, "1-477-935-8478 x6430", false, null, false, "Leopoldo_Corkery", "ola.org" },
                    { 7, 0, new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"), new Guid("6867e142-0989-473c-a891-f050afe3abff"), "0b690f63-0536-4c7e-8593-3fdcf9843a4f", "Telly.Hoeger@billy.biz", false, true, null, "Kurtis Weissnat", "TELLY.HOEGER@BILLY.BIZ", "ELWYN.SKILES", null, "210.067.6132", false, null, false, "Elwyn.Skiles", "elvis.io" },
                    { 8, 0, new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"), new Guid("64615c87-7528-4c65-b025-4778e687d32f"), "08b0df4c-8066-481d-bc21-9a41f6f313ff", "Sherwood@rosamond.me", false, true, null, "Nicholas Runolfsdottir V", "SHERWOOD@ROSAMOND.ME", "MAXIME_NIENOW", null, "586.493.6943 x140", false, null, false, "Maxime_Nienow", "jacynthe.com" },
                    { 9, 0, new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"), new Guid("55882d84-c9e3-4c3d-930f-c06534133169"), "34706957-ebaa-4ff8-8381-2e458d31db35", "Chaim_McDermott@dana.io", false, true, null, "Glenna Reichert", "CHAIM_MCDERMOTT@DANA.IO", "DELPHINE", null, "(775)976-6794 x41206", false, null, false, "Delphine", "conrad.com" },
                    { 10, 0, new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"), new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"), "f4f0b21c-797b-4e3e-9bde-0579747d3f12", "Rey.Padberg@karina.biz", false, true, null, "Clementina DuBuque", "REY.PADBERG@KARINA.BIZ", "MORIAH.STANTON", null, "024-648-3804", false, null, false, "Moriah.Stanton", "ambrose.net" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f335b711-b806-4be6-a3c7-dbd857383457"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("55882d84-c9e3-4c3d-930f-c06534133169"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("64615c87-7528-4c65-b025-4778e687d32f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6867e142-0989-473c-a891-f050afe3abff"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8299272d-0423-447a-845b-5d5488e83f58"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("e635145b-c656-4861-8cea-9f8b45282190"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("58d2e5ee-1f5c-4d5b-9f99-1d052e035772"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("6f15bb28-bba0-4251-9836-1875b8af33c8"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("700ab7ec-42db-4bd5-b7a8-d97e5412f426"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("75f521d8-0da0-46fb-9586-67750d5feee1"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("8ccb69ab-612e-441f-9124-44215b2d7e33"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("98f6ddbf-c560-48bc-9ac7-10ece81b7821"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("a11a4dfb-3916-46c3-a245-73ce896cceba"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("b017c6c3-8717-4a59-a8fe-b9935251fb6a"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("d62481e7-d381-4f3e-b739-3a0a095ea01d"));

            migrationBuilder.DeleteData(
                table: "Geos",
                keyColumn: "Id",
                keyValue: new Guid("ea06a4d5-c2cd-4504-8fe9-066d79c18664"));
        }
    }
}
