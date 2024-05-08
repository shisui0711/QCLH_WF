﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLCHWF.Models;

#nullable disable

namespace QLCHWF.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20231124013740_update_permissionV2")]
    partial class update_permissionV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLCHWF.Models.AppInfo", b =>
                {
                    b.Property<string>("AppName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppName");

                    b.ToTable("AppInfos");

                    b.HasData(
                        new
                        {
                            AppName = "Cửa hàng của bạn",
                            Address = "Hưng Yên",
                            Phone = "0987654321"
                        });
                });

            modelBuilder.Entity("QLCHWF.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("QLCHWF.Models.DetailImportOrder", b =>
                {
                    b.Property<int>("DetailOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailOrderID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("DetailOrderID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("DetailImportOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.DetailSalesOrder", b =>
                {
                    b.Property<int>("DetailOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailOrderID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("DetailOrderID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("DetailSalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("QLCHWF.Models.ImportOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<int>("ProviderID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProviderID");

                    b.ToTable("ImportOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionID"));

                    b.Property<bool>("CanCreateCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateUserRole")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreatedProvider")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteProvider")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteUserRole")
                        .HasColumnType("bit");

                    b.Property<bool>("CanExportImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanExportSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanPrintImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanPrintSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadDetailImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadDetailSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadImportOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadOptions")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadProvider")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadSalesOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadStatistics")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadUser")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadUserRole")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateProvider")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateUserRole")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.HasKey("PermissionID");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionID = 1,
                            CanCreateCustomer = true,
                            CanCreateEmployee = false,
                            CanCreateImportOrder = false,
                            CanCreateProduct = false,
                            CanCreateSalesOrder = false,
                            CanCreateUserRole = false,
                            CanCreatedProvider = false,
                            CanDeleteCustomer = true,
                            CanDeleteEmployee = false,
                            CanDeleteImportOrder = false,
                            CanDeleteProduct = false,
                            CanDeleteProvider = false,
                            CanDeleteSalesOrder = false,
                            CanDeleteUserRole = false,
                            CanExportImportOrder = false,
                            CanExportSalesOrder = false,
                            CanPrintImportOrder = false,
                            CanPrintSalesOrder = false,
                            CanReadCustomer = true,
                            CanReadDetailImportOrder = true,
                            CanReadDetailSalesOrder = true,
                            CanReadEmployee = false,
                            CanReadImportOrder = false,
                            CanReadOptions = false,
                            CanReadProduct = false,
                            CanReadProvider = false,
                            CanReadSalesOrder = false,
                            CanReadStatistics = false,
                            CanReadUser = false,
                            CanReadUserRole = false,
                            CanUpdateCustomer = true,
                            CanUpdateEmployee = false,
                            CanUpdateProduct = false,
                            CanUpdateProvider = false,
                            CanUpdateUserRole = false,
                            IsAdmin = false
                        });
                });

            modelBuilder.Entity("QLCHWF.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("CalculationUnit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal?>("ImportUnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("QLCHWF.Models.Provider", b =>
                {
                    b.Property<int>("ProviderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProviderID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ProviderID");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("QLCHWF.Models.SalesOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<decimal>("ChangePrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.User", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lock")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID", "RoleID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QLCHWF.Models.UserRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionID")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleID");

                    b.HasIndex("PermissionID")
                        .IsUnique();

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            DateCreated = new DateTime(2023, 11, 24, 8, 37, 40, 618, DateTimeKind.Local).AddTicks(1611),
                            PermissionID = 1,
                            RoleName = "Nhân viên"
                        });
                });

            modelBuilder.Entity("QLCHWF.Models.DetailImportOrder", b =>
                {
                    b.HasOne("QLCHWF.Models.ImportOrder", "ImportOrder")
                        .WithMany("DetailImportOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCHWF.Models.Product", "Product")
                        .WithMany("DetailImportOrders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImportOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("QLCHWF.Models.DetailSalesOrder", b =>
                {
                    b.HasOne("QLCHWF.Models.SalesOrder", "SalesOrder")
                        .WithMany("DetailSalesOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCHWF.Models.Product", "Product")
                        .WithMany("DetailSalesOrders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SalesOrder");
                });

            modelBuilder.Entity("QLCHWF.Models.ImportOrder", b =>
                {
                    b.HasOne("QLCHWF.Models.Employee", "Employee")
                        .WithMany("ImportOrders")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("QLCHWF.Models.Provider", "Provider")
                        .WithMany("ImportOrders")
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("QLCHWF.Models.SalesOrder", b =>
                {
                    b.HasOne("QLCHWF.Models.Customer", "Customer")
                        .WithMany("SalesOrders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCHWF.Models.Employee", "Employee")
                        .WithMany("SalesOrders")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QLCHWF.Models.User", b =>
                {
                    b.HasOne("QLCHWF.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCHWF.Models.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("QLCHWF.Models.UserRole", b =>
                {
                    b.HasOne("QLCHWF.Models.Permission", "Permission")
                        .WithOne("UserRole")
                        .HasForeignKey("QLCHWF.Models.UserRole", "PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("QLCHWF.Models.Customer", b =>
                {
                    b.Navigation("SalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.Employee", b =>
                {
                    b.Navigation("ImportOrders");

                    b.Navigation("SalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.ImportOrder", b =>
                {
                    b.Navigation("DetailImportOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.Permission", b =>
                {
                    b.Navigation("UserRole")
                        .IsRequired();
                });

            modelBuilder.Entity("QLCHWF.Models.Product", b =>
                {
                    b.Navigation("DetailImportOrders");

                    b.Navigation("DetailSalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.Provider", b =>
                {
                    b.Navigation("ImportOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.SalesOrder", b =>
                {
                    b.Navigation("DetailSalesOrders");
                });

            modelBuilder.Entity("QLCHWF.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
