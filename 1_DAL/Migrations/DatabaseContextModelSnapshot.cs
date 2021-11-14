﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Context;

namespace _1_DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Busy")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Floor" }, "IX_BanAn_Floor");

                    b.ToTable("BanAn");
                });

            modelBuilder.Entity("_1_DAL.Models.CachCheBien", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CachCheBien");
                });

            modelBuilder.Entity("_1_DAL.Models.CongThuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("IdMon")
                        .HasColumnType("int");

                    b.Property<int>("IdNguyenLieu")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdMon" }, "IX_CongThuc_IdMon");

                    b.HasIndex(new[] { "IdNguyenLieu" }, "IX_CongThuc_IdNguyenLieu");

                    b.ToTable("CongThuc");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMucFood", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DanhMucFood");
                });

            modelBuilder.Entity("_1_DAL.Models.DonVi", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DonVi");
                });

            modelBuilder.Entity("_1_DAL.Models.Floor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Floor");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCheckIn")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateCheckOut")
                        .HasColumnType("date");

                    b.Property<int>("IdnhanVien")
                        .HasColumnType("int")
                        .HasColumnName("IDNhanVien");

                    b.Property<int>("Idtable")
                        .HasColumnType("int")
                        .HasColumnName("IDtable");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalMoney")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdnhanVien" }, "IX_HoaDon_IDNhanVien");

                    b.HasIndex(new[] { "Idtable" }, "IX_HoaDon_IDtable");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Idbill")
                        .HasColumnType("int")
                        .HasColumnName("IDBill");

                    b.Property<int>("Idfood")
                        .HasColumnType("int")
                        .HasColumnName("IDFood");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Idfood");

                    b.HasIndex(new[] { "Idbill" }, "IX_HoaDonChiTiet_IDBill");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.MonAnChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Anh")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Idcategory")
                        .HasColumnType("int")
                        .HasColumnName("IDCategory");

                    b.Property<int>("Idmethod")
                        .HasColumnType("int")
                        .HasColumnName("IDMethod");

                    b.Property<int>("Idunit")
                        .HasColumnType("int")
                        .HasColumnName("IDUnit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idmethod");

                    b.HasIndex(new[] { "Idcategory" }, "IX_MonAnChiTiet_IDCategory");

                    b.HasIndex(new[] { "Idunit" }, "IX_MonAnChiTiet_IDUnit");

                    b.ToTable("MonAnChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.NguyenLieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NguyenLieu");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNv")
                        .HasColumnType("int")
                        .HasColumnName("MaNV");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<float>("Name")
                        .HasColumnType("real");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("MaNv");

                    b.HasIndex(new[] { "Role" }, "IX_NhanVien_Role");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1_DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("_1_DAL.Models.ThucDon", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("IdchiTiet")
                        .HasColumnType("int")
                        .HasColumnName("IDChiTiet");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdchiTiet");

                    b.ToTable("ThucDon");
                });

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.HasOne("_1_DAL.Models.Floor", "FloorNavigation")
                        .WithMany("BanAns")
                        .HasForeignKey("Floor")
                        .HasConstraintName("FK_BanAn_Floor");

                    b.Navigation("FloorNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.CongThuc", b =>
                {
                    b.HasOne("_1_DAL.Models.MonAnChiTiet", "IdMonNavigation")
                        .WithMany("CongThucs")
                        .HasForeignKey("IdMon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.NguyenLieu", "IdNguyenLieuNavigation")
                        .WithMany("CongThucs")
                        .HasForeignKey("IdNguyenLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdMonNavigation");

                    b.Navigation("IdNguyenLieuNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1_DAL.Models.NhanVien", "IdnhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdnhanVien")
                        .HasConstraintName("FK_HoaDon_NhanVien")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.BanAn", "IdtableNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("Idtable")
                        .HasConstraintName("FK_HoaDon_BanAn")
                        .IsRequired();

                    b.Navigation("IdnhanVienNavigation");

                    b.Navigation("IdtableNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.HoaDon", "IdbillNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("Idbill")
                        .HasConstraintName("FK_HoaDonChiTiet_HoaDon")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.MonAnChiTiet", "IdfoodNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("Idfood")
                        .HasConstraintName("FK_HoaDonChiTiet_MonAnChiTiet")
                        .IsRequired();

                    b.Navigation("IdbillNavigation");

                    b.Navigation("IdfoodNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.MonAnChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.DanhMucFood", "IdcategoryNavigation")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idcategory")
                        .HasConstraintName("FK_MonAnChiTiet_DanhMucFood")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.CachCheBien", "IdmethodNavigation")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idmethod")
                        .HasConstraintName("FK_MonAnChiTiet_CachChebien")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.DonVi", "IdunitNavigation")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idunit")
                        .HasConstraintName("FK_MonAnChiTiet_DonVi")
                        .IsRequired();

                    b.Navigation("IdcategoryNavigation");

                    b.Navigation("IdmethodNavigation");

                    b.Navigation("IdunitNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL.Models.Role", "RoleNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("Role")
                        .HasConstraintName("FK_NhanVien_Roles")
                        .IsRequired();

                    b.Navigation("RoleNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.ThucDon", b =>
                {
                    b.HasOne("_1_DAL.Models.MonAnChiTiet", "IdchiTietNavigation")
                        .WithMany("ThucDons")
                        .HasForeignKey("IdchiTiet")
                        .HasConstraintName("FK_ThucDon_MonAnChiTiet")
                        .IsRequired();

                    b.Navigation("IdchiTietNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.CachCheBien", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMucFood", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.DonVi", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.Floor", b =>
                {
                    b.Navigation("BanAns");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.MonAnChiTiet", b =>
                {
                    b.Navigation("CongThucs");

                    b.Navigation("HoaDonChiTiets");

                    b.Navigation("ThucDons");
                });

            modelBuilder.Entity("_1_DAL.Models.NguyenLieu", b =>
                {
                    b.Navigation("CongThucs");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.Role", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
