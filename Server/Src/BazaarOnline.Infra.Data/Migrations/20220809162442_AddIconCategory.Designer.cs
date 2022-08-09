﻿// <auto-generated />
using System;
using BazaarOnline.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BazaarOnline.Infra.Data.Migrations
{
    [DbContext(typeof(BazaarDbContext))]
    [Migration("20220809162442_AddIconCategory")]
    partial class AddIconCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icon")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Locations.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "آذربایجان شرقی"
                        },
                        new
                        {
                            Id = 2,
                            Name = "آذربایجان غربی"
                        },
                        new
                        {
                            Id = 3,
                            Name = "اردبیل"
                        },
                        new
                        {
                            Id = 4,
                            Name = "اصفهان"
                        },
                        new
                        {
                            Id = 5,
                            Name = "البرز"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ایلام"
                        },
                        new
                        {
                            Id = 7,
                            Name = "بوشهر"
                        },
                        new
                        {
                            Id = 8,
                            Name = "تهران"
                        },
                        new
                        {
                            Id = 9,
                            Name = "چهارمحال وبختیاری"
                        },
                        new
                        {
                            Id = 10,
                            Name = "خراسان جنوبی"
                        },
                        new
                        {
                            Id = 11,
                            Name = "خراسان رضوی"
                        },
                        new
                        {
                            Id = 12,
                            Name = "خراسان شمالی"
                        },
                        new
                        {
                            Id = 13,
                            Name = "خوزستان"
                        },
                        new
                        {
                            Id = 14,
                            Name = "زنجان"
                        },
                        new
                        {
                            Id = 15,
                            Name = "سمنان"
                        },
                        new
                        {
                            Id = 16,
                            Name = "سیستان وبلوچستان"
                        },
                        new
                        {
                            Id = 17,
                            Name = "فارس"
                        },
                        new
                        {
                            Id = 18,
                            Name = "قزوین"
                        },
                        new
                        {
                            Id = 19,
                            Name = "قم"
                        },
                        new
                        {
                            Id = 20,
                            Name = "کردستان"
                        },
                        new
                        {
                            Id = 21,
                            Name = "کرمان"
                        },
                        new
                        {
                            Id = 22,
                            Name = "کرمانشاه"
                        },
                        new
                        {
                            Id = 23,
                            Name = "کهگیلویه وبویراحمد"
                        },
                        new
                        {
                            Id = 24,
                            Name = "گلستان"
                        },
                        new
                        {
                            Id = 25,
                            Name = "گیلان"
                        },
                        new
                        {
                            Id = 26,
                            Name = "لرستان"
                        },
                        new
                        {
                            Id = 27,
                            Name = "مازندران"
                        },
                        new
                        {
                            Id = 28,
                            Name = "مرکزی"
                        },
                        new
                        {
                            Id = 29,
                            Name = "هرمزگان"
                        },
                        new
                        {
                            Id = 30,
                            Name = "همدان"
                        },
                        new
                        {
                            Id = 31,
                            Name = "یزد"
                        });
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PermissionGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("PermissionGroupId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PermissionGroupId = 1,
                            Title = "ساخت کاربر"
                        },
                        new
                        {
                            Id = 2,
                            PermissionGroupId = 1,
                            Title = "ویرایش کاربر"
                        },
                        new
                        {
                            Id = 3,
                            PermissionGroupId = 3,
                            Title = "ساخت دسته بندی"
                        },
                        new
                        {
                            Id = 4,
                            PermissionGroupId = 3,
                            Title = "ویرایش دسته بندی"
                        },
                        new
                        {
                            Id = 5,
                            PermissionGroupId = 2,
                            Title = "ساخت آگهی"
                        },
                        new
                        {
                            Id = 6,
                            PermissionGroupId = 2,
                            Title = "ویرایش آگهی"
                        },
                        new
                        {
                            Id = 7,
                            PermissionGroupId = 1,
                            Title = "ویرایش نقش های کاربر"
                        },
                        new
                        {
                            Id = 8,
                            PermissionGroupId = 1,
                            Title = "مشاهده مشخصات کاربران"
                        },
                        new
                        {
                            Id = 9,
                            PermissionGroupId = 4,
                            Title = "مشاهده دسترسی ها"
                        },
                        new
                        {
                            Id = 10,
                            PermissionGroupId = 4,
                            Title = "مشاهده اطلاعات نقس"
                        },
                        new
                        {
                            Id = 11,
                            PermissionGroupId = 4,
                            Title = "ساخت نقش"
                        },
                        new
                        {
                            Id = 12,
                            PermissionGroupId = 4,
                            Title = "ویرایش نقش"
                        },
                        new
                        {
                            Id = 13,
                            PermissionGroupId = 4,
                            Title = "حذف نقش"
                        },
                        new
                        {
                            Id = 14,
                            PermissionGroupId = 2,
                            Title = "حذف آگهی"
                        },
                        new
                        {
                            Id = 15,
                            PermissionGroupId = 3,
                            Title = "حذف دسته بندی"
                        },
                        new
                        {
                            Id = 16,
                            PermissionGroupId = 1,
                            Title = "حذف کاربر"
                        });
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.PermissionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("PermissionGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "User Management"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Advertisement Management"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Category Management"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Role Management"
                        });
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "مدیر کل"
                        },
                        new
                        {
                            Id = 2,
                            Title = "ادمین"
                        },
                        new
                        {
                            Id = 3,
                            Title = "پشتیبان"
                        },
                        new
                        {
                            Id = 4,
                            Title = "کاربر عادی"
                        });
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 7
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 9
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 10
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 11
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 12
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 13
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 14
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 15
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 16
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 5
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 6
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 9
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 10
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 11
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 12
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 13
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 14
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 15
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 16
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 4,
                            PermissionId = 5
                        });
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Users.ActiveCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email", "Code");

                    b.ToTable("ActiveCodes");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Users.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Categories.Category", b =>
                {
                    b.HasOne("BazaarOnline.Domain.Entities.Categories.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.Permission", b =>
                {
                    b.HasOne("BazaarOnline.Domain.Entities.Permissions.PermissionGroup", "PermissionGroup")
                        .WithMany("Permissions")
                        .HasForeignKey("PermissionGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionGroup");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.RolePermission", b =>
                {
                    b.HasOne("BazaarOnline.Domain.Entities.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaarOnline.Domain.Entities.Permissions.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Users.UserRole", b =>
                {
                    b.HasOne("BazaarOnline.Domain.Entities.Permissions.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaarOnline.Domain.Entities.Users.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Categories.Category", b =>
                {
                    b.Navigation("ChildCategories");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.PermissionGroup", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Permissions.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BazaarOnline.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
