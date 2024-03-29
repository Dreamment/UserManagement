﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.EFCore;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231216105011_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GeoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeoId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"),
                            City = "Gwenborough",
                            GeoId = new Guid("75f521d8-0da0-46fb-9586-67750d5feee1"),
                            Street = "Kulas Light",
                            Suite = "Apt. 556",
                            Zipcode = "92998-3874"
                        },
                        new
                        {
                            Id = new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"),
                            City = "Wisokyburgh",
                            GeoId = new Guid("700ab7ec-42db-4bd5-b7a8-d97e5412f426"),
                            Street = "Victor Plains",
                            Suite = "Suite 879",
                            Zipcode = "90566-7771"
                        },
                        new
                        {
                            Id = new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"),
                            City = "McKenziehaven",
                            GeoId = new Guid("6f15bb28-bba0-4251-9836-1875b8af33c8"),
                            Street = "Douglas Extension",
                            Suite = "Suite 847",
                            Zipcode = "59590-4157"
                        },
                        new
                        {
                            Id = new Guid("f335b711-b806-4be6-a3c7-dbd857383457"),
                            City = "South Elvis",
                            GeoId = new Guid("b017c6c3-8717-4a59-a8fe-b9935251fb6a"),
                            Street = "Hoeger Mall",
                            Suite = "Apt. 692",
                            Zipcode = "53919-4257"
                        },
                        new
                        {
                            Id = new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"),
                            City = "Roscoeview",
                            GeoId = new Guid("a11a4dfb-3916-46c3-a245-73ce896cceba"),
                            Street = "Skiles Walks",
                            Suite = "Suite 351",
                            Zipcode = "33263"
                        },
                        new
                        {
                            Id = new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"),
                            City = "South Christy",
                            GeoId = new Guid("8ccb69ab-612e-441f-9124-44215b2d7e33"),
                            Street = "Norberto Crossing",
                            Suite = "Apt. 950",
                            Zipcode = "23505-1337"
                        },
                        new
                        {
                            Id = new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"),
                            City = "Howemouth",
                            GeoId = new Guid("d62481e7-d381-4f3e-b739-3a0a095ea01d"),
                            Street = "Rex Trail",
                            Suite = "Suite 280",
                            Zipcode = "58804-1099"
                        },
                        new
                        {
                            Id = new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"),
                            City = "Aliyaview",
                            GeoId = new Guid("58d2e5ee-1f5c-4d5b-9f99-1d052e035772"),
                            Street = "Ellsworth Summit",
                            Suite = "Suite 729",
                            Zipcode = "45169"
                        },
                        new
                        {
                            Id = new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"),
                            City = "Bartholomebury",
                            GeoId = new Guid("ea06a4d5-c2cd-4504-8fe9-066d79c18664"),
                            Street = "Dayna Park",
                            Suite = "Suite 449",
                            Zipcode = "76495-3109"
                        },
                        new
                        {
                            Id = new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"),
                            City = "Lebsackbury",
                            GeoId = new Guid("98f6ddbf-c560-48bc-9ac7-10ece81b7821"),
                            Street = "Kattie Turnpike",
                            Suite = "Suite 198",
                            Zipcode = "31428-2261"
                        });
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatchPhrase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8299272d-0423-447a-845b-5d5488e83f58"),
                            Bs = "harness real-time e-markets",
                            CatchPhrase = "Multi-layered client-server neural-net",
                            Name = "Romaguera-Crona"
                        },
                        new
                        {
                            Id = new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"),
                            Bs = "synergize scalable supply-chains",
                            CatchPhrase = "Proactive didactic contingency",
                            Name = "Deckow-Crist"
                        },
                        new
                        {
                            Id = new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"),
                            Bs = "e-enable strategic applications",
                            CatchPhrase = "Face to face bifurcated interface",
                            Name = "Romaguera-Jacobson"
                        },
                        new
                        {
                            Id = new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"),
                            Bs = "transition cutting-edge web services",
                            CatchPhrase = "Multi-tiered zero tolerance productivity",
                            Name = "Robel-Corkery"
                        },
                        new
                        {
                            Id = new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"),
                            Bs = "revolutionize end-to-end systems",
                            CatchPhrase = "User-centric fault-tolerant solution",
                            Name = "Keebler LLC"
                        },
                        new
                        {
                            Id = new Guid("e635145b-c656-4861-8cea-9f8b45282190"),
                            Bs = "e-enable innovative applications",
                            CatchPhrase = "Synchronised bottom-line interface",
                            Name = "Considine-Lockman"
                        },
                        new
                        {
                            Id = new Guid("6867e142-0989-473c-a891-f050afe3abff"),
                            Bs = "generate enterprise e-tailers",
                            CatchPhrase = "Configurable multimedia task-force",
                            Name = "Johns Group"
                        },
                        new
                        {
                            Id = new Guid("64615c87-7528-4c65-b025-4778e687d32f"),
                            Bs = "e-enable extensible e-tailers",
                            CatchPhrase = "Implemented secondary concept",
                            Name = "Abernathy Group"
                        },
                        new
                        {
                            Id = new Guid("55882d84-c9e3-4c3d-930f-c06534133169"),
                            Bs = "aggregate real-time technologies",
                            CatchPhrase = "Switchable contextually-based project",
                            Name = "Yost and Sons"
                        },
                        new
                        {
                            Id = new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"),
                            Bs = "target end-to-end models",
                            CatchPhrase = "Centralized empowering task-force",
                            Name = "Hoeger LLC"
                        });
                });

            modelBuilder.Entity("Entities.Models.Geo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Lat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Geos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75f521d8-0da0-46fb-9586-67750d5feee1"),
                            Lat = "-37.3159",
                            Lng = "81.1496"
                        },
                        new
                        {
                            Id = new Guid("700ab7ec-42db-4bd5-b7a8-d97e5412f426"),
                            Lat = "-43.9509",
                            Lng = "-34.4618"
                        },
                        new
                        {
                            Id = new Guid("6f15bb28-bba0-4251-9836-1875b8af33c8"),
                            Lat = "-68.6102",
                            Lng = "-47.0653"
                        },
                        new
                        {
                            Id = new Guid("b017c6c3-8717-4a59-a8fe-b9935251fb6a"),
                            Lat = "29.4572",
                            Lng = "-164.2990"
                        },
                        new
                        {
                            Id = new Guid("a11a4dfb-3916-46c3-a245-73ce896cceba"),
                            Lat = "-31.8129",
                            Lng = "62.5342"
                        },
                        new
                        {
                            Id = new Guid("8ccb69ab-612e-441f-9124-44215b2d7e33"),
                            Lat = "-71.4197",
                            Lng = "71.7478"
                        },
                        new
                        {
                            Id = new Guid("d62481e7-d381-4f3e-b739-3a0a095ea01d"),
                            Lat = "24.8918",
                            Lng = "21.8984"
                        },
                        new
                        {
                            Id = new Guid("58d2e5ee-1f5c-4d5b-9f99-1d052e035772"),
                            Lat = "-14.3990",
                            Lng = "-120.7677"
                        },
                        new
                        {
                            Id = new Guid("ea06a4d5-c2cd-4504-8fe9-066d79c18664"),
                            Lat = "24.6463",
                            Lng = "-168.8889"
                        },
                        new
                        {
                            Id = new Guid("98f6ddbf-c560-48bc-9ac7-10ece81b7821"),
                            Lat = "-38.2386",
                            Lng = "57.2232"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            AddressId = new Guid("2b0f2985-096b-4431-a7ec-e59ac03ef50e"),
                            CompanyId = new Guid("8299272d-0423-447a-845b-5d5488e83f58"),
                            ConcurrencyStamp = "e83cd856-befd-4f51-84bf-93e03c504c3b",
                            Email = "Sincere@april.biz",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Leanne Graham",
                            NormalizedEmail = "SINCERE@APRIL.BIZ",
                            NormalizedUserName = "BRET",
                            PhoneNumber = "1-770-736-8031 x56442",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Bret",
                            Website = "hildegard.org"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            AddressId = new Guid("09cb797a-ec94-498c-977d-ec2e30e34fa9"),
                            CompanyId = new Guid("c80b52bb-0fcc-4e9d-aab2-e8dbda165061"),
                            ConcurrencyStamp = "71d948a8-5dc3-4cd5-8edc-c0fb46273a29",
                            Email = "Shanna@melissa.tv",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Ervin Howell",
                            NormalizedEmail = "SHANNA@MELISSA.TV",
                            NormalizedUserName = "ANTONETTE",
                            PhoneNumber = "010-692-6593 x09125",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Antonette",
                            Website = "anastasia.net"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            AddressId = new Guid("46747134-69dc-4df8-9ba2-d662939b9d7e"),
                            CompanyId = new Guid("876ccb95-e66b-4c79-9c8f-dbc0e6162728"),
                            ConcurrencyStamp = "40f1a05c-aaf0-4726-b731-c4af388cd4af",
                            Email = "Nathan@yesenia.net",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Clementine Bauch",
                            NormalizedEmail = "NATHAN@YESENIA.NET",
                            NormalizedUserName = "SAMANTHA",
                            PhoneNumber = "1-463-123-4447",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Samantha",
                            Website = "ramiro.info"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            AddressId = new Guid("f335b711-b806-4be6-a3c7-dbd857383457"),
                            CompanyId = new Guid("659cc20b-6f37-4bfb-97ef-d272e686a021"),
                            ConcurrencyStamp = "b95c6f60-07e0-4bc9-9ca7-7c691e629522",
                            Email = "Julianne.OConner@kory.org",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Patricia Lebsack",
                            NormalizedEmail = "JULIANNE.OCONNER@KORY.ORG",
                            NormalizedUserName = "KARIANNE",
                            PhoneNumber = "493-170-9623 x156",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Karianne",
                            Website = "kale.biz"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            AddressId = new Guid("697ab928-6826-4bfb-93dc-cce6c5e151a7"),
                            CompanyId = new Guid("a453e3a6-30ee-43c9-a9f1-74f9685e5f62"),
                            ConcurrencyStamp = "01e7146b-bb1f-4a9b-98c0-53aa3e6b4c6f",
                            Email = "Lucio_Hettinger@annie.ca",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Chelsey Dietrich",
                            NormalizedEmail = "LUCIO_HETTINGER@ANNIE.CA",
                            NormalizedUserName = "KAMREN",
                            PhoneNumber = "(254)954-1289",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Kamren",
                            Website = "demarco.info"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            AddressId = new Guid("1a4a6c4b-b1ef-4ef1-8ba0-f6016a89a160"),
                            CompanyId = new Guid("e635145b-c656-4861-8cea-9f8b45282190"),
                            ConcurrencyStamp = "7a1ab073-9da7-434c-9aa8-71fbbff13a00",
                            Email = "Karley_Dach@jasper.info",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Mrs. Dennis Schulist",
                            NormalizedEmail = "KARLEY_DACH@JASPER.INFO",
                            NormalizedUserName = "LEOPOLDO_CORKERY",
                            PhoneNumber = "1-477-935-8478 x6430",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Leopoldo_Corkery",
                            Website = "ola.org"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            AddressId = new Guid("dedc0001-b0b0-42e4-97c5-7ca00f4a4530"),
                            CompanyId = new Guid("6867e142-0989-473c-a891-f050afe3abff"),
                            ConcurrencyStamp = "0b690f63-0536-4c7e-8593-3fdcf9843a4f",
                            Email = "Telly.Hoeger@billy.biz",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Kurtis Weissnat",
                            NormalizedEmail = "TELLY.HOEGER@BILLY.BIZ",
                            NormalizedUserName = "ELWYN.SKILES",
                            PhoneNumber = "210.067.6132",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Elwyn.Skiles",
                            Website = "elvis.io"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            AddressId = new Guid("78694c54-b881-49e6-80e2-faf4aeea33a9"),
                            CompanyId = new Guid("64615c87-7528-4c65-b025-4778e687d32f"),
                            ConcurrencyStamp = "08b0df4c-8066-481d-bc21-9a41f6f313ff",
                            Email = "Sherwood@rosamond.me",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Nicholas Runolfsdottir V",
                            NormalizedEmail = "SHERWOOD@ROSAMOND.ME",
                            NormalizedUserName = "MAXIME_NIENOW",
                            PhoneNumber = "586.493.6943 x140",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Maxime_Nienow",
                            Website = "jacynthe.com"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            AddressId = new Guid("e80a5a80-425f-44f0-828c-a80239e70e9f"),
                            CompanyId = new Guid("55882d84-c9e3-4c3d-930f-c06534133169"),
                            ConcurrencyStamp = "34706957-ebaa-4ff8-8381-2e458d31db35",
                            Email = "Chaim_McDermott@dana.io",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Glenna Reichert",
                            NormalizedEmail = "CHAIM_MCDERMOTT@DANA.IO",
                            NormalizedUserName = "DELPHINE",
                            PhoneNumber = "(775)976-6794 x41206",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Delphine",
                            Website = "conrad.com"
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            AddressId = new Guid("c068ebf3-e52a-4cf9-be85-1e7ca61454e6"),
                            CompanyId = new Guid("28faa720-ee3c-4f4e-aa65-d62cadcb59e5"),
                            ConcurrencyStamp = "f4f0b21c-797b-4e3e-9bde-0579747d3f12",
                            Email = "Rey.Padberg@karina.biz",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Clementina DuBuque",
                            NormalizedEmail = "REY.PADBERG@KARINA.BIZ",
                            NormalizedUserName = "MORIAH.STANTON",
                            PhoneNumber = "024-648-3804",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Moriah.Stanton",
                            Website = "ambrose.net"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.HasOne("Entities.Models.Geo", "Geo")
                        .WithMany("Addresses")
                        .HasForeignKey("GeoId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_Address_Geo");

                    b.Navigation("Geo");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Address", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_User_Address");

                    b.HasOne("Entities.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_User_Company");

                    b.Navigation("Address");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Models.Geo", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
