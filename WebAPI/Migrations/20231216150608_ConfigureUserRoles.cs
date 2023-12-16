using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class ConfigureUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "dab55e26-8f87-47fa-b1d8-72e18ec55503", "User", "USER" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 10 });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"), new Guid("8299272d-0423-447a-845b-5d5488e83f58"), "e83cd856-befd-4f51-84bf-93e03c504c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"), new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"), "71d948a8-5dc3-4cd5-8edc-c0fb46273a29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"), new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"), "40f1a05c-aaf0-4726-b731-c4af388cd4af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("f335b711-b806-4be6-a3c7-dbd857383457"), new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"), "b95c6f60-07e0-4bc9-9ca7-7c691e629522" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"), new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"), "01e7146b-bb1f-4a9b-98c0-53aa3e6b4c6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"), new Guid("e635145b-c656-4861-8cea-9f8b45282190"), "7a1ab073-9da7-434c-9aa8-71fbbff13a00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"), new Guid("6867e142-0989-473c-a891-f050afe3abff"), "0b690f63-0536-4c7e-8593-3fdcf9843a4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"), new Guid("64615c87-7528-4c65-b025-4778e687d32f"), "08b0df4c-8066-481d-bc21-9a41f6f313ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"), new Guid("55882d84-c9e3-4c3d-930f-c06534133169"), "34706957-ebaa-4ff8-8381-2e458d31db35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressId", "CompanyId", "ConcurrencyStamp" },
                values: new object[] { new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"), new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"), "f4f0b21c-797b-4e3e-9bde-0579747d3f12" });
        }
    }
}
