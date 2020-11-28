using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnAsp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "loaisanpham",
                columns: table => new
                {
                    IdLSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLSP = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaisanpham", x => x.IdLSP);
                });

            migrationBuilder.CreateTable(
                name: "nhacungcap",
                columns: table => new
                {
                    IdNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SdtNCC = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhacungcap", x => x.IdNCC);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotenUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmailUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SdtUser = table.Column<int>(type: "int", nullable: false),
                    DiachiUser = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UsernameUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PasswordUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrangthaiUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "sanpham",
                columns: table => new
                {
                    IdSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Soluongton = table.Column<int>(type: "int", nullable: false),
                    IdNCC = table.Column<int>(type: "int", nullable: false),
                    IdLSP = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    loaspIdLSP = table.Column<int>(type: "int", nullable: true),
                    nhacungcapIdNCC = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanpham", x => x.IdSP);
                    table.ForeignKey(
                        name: "FK_sanpham_loaisanpham_loaspIdLSP",
                        column: x => x.loaspIdLSP,
                        principalTable: "loaisanpham",
                        principalColumn: "IdLSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sanpham_nhacungcap_nhacungcapIdNCC",
                        column: x => x.nhacungcapIdNCC,
                        principalTable: "nhacungcap",
                        principalColumn: "IdNCC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hoadon",
                columns: table => new
                {
                    IdHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgaylapHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Thanhtien = table.Column<double>(type: "float", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    userIdUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadon", x => x.IdHD);
                    table.ForeignKey(
                        name: "FK_hoadon_user_userIdUser",
                        column: x => x.userIdUser,
                        principalTable: "user",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "binhluan",
                columns: table => new
                {
                    IdBL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Noidung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_binhluan", x => x.IdBL);
                    table.ForeignKey(
                        name: "FK_binhluan_sanpham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "sanpham",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chitiethoadon",
                columns: table => new
                {
                    IdCTHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Tongtien = table.Column<double>(type: "float", nullable: false),
                    IdHD = table.Column<int>(type: "int", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    hoadonIdHD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitiethoadon", x => x.IdCTHD);
                    table.ForeignKey(
                        name: "FK_chitiethoadon_hoadon_hoadonIdHD",
                        column: x => x.hoadonIdHD,
                        principalTable: "hoadon",
                        principalColumn: "IdHD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_binhluan_IdSP",
                table: "binhluan",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_chitiethoadon_hoadonIdHD",
                table: "chitiethoadon",
                column: "hoadonIdHD");

            migrationBuilder.CreateIndex(
                name: "IX_hoadon_userIdUser",
                table: "hoadon",
                column: "userIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_sanpham_loaspIdLSP",
                table: "sanpham",
                column: "loaspIdLSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanpham_nhacungcapIdNCC",
                table: "sanpham",
                column: "nhacungcapIdNCC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "binhluan");

            migrationBuilder.DropTable(
                name: "chitiethoadon");

            migrationBuilder.DropTable(
                name: "sanpham");

            migrationBuilder.DropTable(
                name: "hoadon");

            migrationBuilder.DropTable(
                name: "loaisanpham");

            migrationBuilder.DropTable(
                name: "nhacungcap");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
