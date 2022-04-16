using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuanVanTotNghiep.Data.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlAvatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsPersion = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillCheckoutProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalBill = table.Column<double>(type: "float", nullable: false),
                    TotalProducts = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillCheckoutProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSubCategory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBrands = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlBrands = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleOffProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleOff = table.Column<double>(type: "float", nullable: false),
                    PromotionDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromotionExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOffProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSmallSub = table.Column<int>(type: "int", nullable: true),
                    IdParentCategory = table.Column<int>(type: "int", nullable: true),
                    ParentCategorysId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorys_ParentCategorys_ParentCategorysId",
                        column: x => x.ParentCategorysId,
                        principalTable: "ParentCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmallSubCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProduct = table.Column<int>(type: "int", nullable: true),
                    IdSubCategory = table.Column<int>(type: "int", nullable: true),
                    SubCategorysId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallSubCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmallSubCategorys_SubCategorys_SubCategorysId",
                        column: x => x.SubCategorysId,
                        principalTable: "SubCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<double>(type: "float", nullable: false),
                    UrlImageProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountProduct = table.Column<int>(type: "int", nullable: false),
                    ProductAddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryProduct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriceSaleOffProduct = table.Column<double>(type: "float", nullable: false),
                    MassProduct = table.Column<double>(type: "float", nullable: false),
                    StatusProduct = table.Column<bool>(type: "bit", nullable: true),
                    IdSmallSubCategory = table.Column<int>(type: "int", nullable: true),
                    IdManufacturers = table.Column<int>(type: "int", nullable: true),
                    IdComment = table.Column<int>(type: "int", nullable: true),
                    IdBrands = table.Column<int>(type: "int", nullable: true),
                    IdDatHang = table.Column<int>(type: "int", nullable: true),
                    IdListImage = table.Column<int>(type: "int", nullable: true),
                    IdSaleOff = table.Column<int>(type: "int", nullable: true),
                    IdMass = table.Column<int>(type: "int", nullable: true),
                    ManufacturersId = table.Column<int>(type: "int", nullable: true),
                    ProductBrandsId = table.Column<int>(type: "int", nullable: true),
                    SaleOffProductId = table.Column<int>(type: "int", nullable: true),
                    SmallSubCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailProducts_Manufacturers_ManufacturersId",
                        column: x => x.ManufacturersId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailProducts_ProductBrands_ProductBrandsId",
                        column: x => x.ProductBrandsId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailProducts_SaleOffProducts_SaleOffProductId",
                        column: x => x.SaleOffProductId,
                        principalTable: "SaleOffProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailProducts_SmallSubCategorys_SmallSubCategoryId",
                        column: x => x.SmallSubCategoryId,
                        principalTable: "SmallSubCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillDetailCheckoutProducts",
                columns: table => new
                {
                    IdCheckout = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    AmountProduct = table.Column<int>(type: "int", nullable: false),
                    TotalBill = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetailCheckoutProducts", x => new { x.IdCheckout, x.IdProduct });
                    table.ForeignKey(
                        name: "FK_BillDetailCheckoutProducts_BillCheckoutProducts_IdCheckout",
                        column: x => x.IdCheckout,
                        principalTable: "BillCheckoutProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetailCheckoutProducts_DetailProducts_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "DetailProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Messages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    BlockComments = table.Column<bool>(type: "bit", nullable: true),
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentProducts_DetailProducts_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "DetailProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsProductImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListProductImages_DetailProducts_IsProductImageId",
                        column: x => x.IsProductImageId,
                        principalTable: "DetailProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MassProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitMass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassProduct = table.Column<double>(type: "float", nullable: false),
                    MassProductsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MassProducts_DetailProducts_MassProductsId",
                        column: x => x.MassProductsId,
                        principalTable: "DetailProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetailCheckoutProducts_IdProduct",
                table: "BillDetailCheckoutProducts",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_CommentProducts_IdProduct",
                table: "CommentProducts",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProducts_ManufacturersId",
                table: "DetailProducts",
                column: "ManufacturersId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProducts_ProductBrandsId",
                table: "DetailProducts",
                column: "ProductBrandsId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProducts_SaleOffProductId",
                table: "DetailProducts",
                column: "SaleOffProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProducts_SmallSubCategoryId",
                table: "DetailProducts",
                column: "SmallSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ListProductImages_IsProductImageId",
                table: "ListProductImages",
                column: "IsProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MassProducts_MassProductsId",
                table: "MassProducts",
                column: "MassProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_SmallSubCategorys_SubCategorysId",
                table: "SmallSubCategorys",
                column: "SubCategorysId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorys_ParentCategorysId",
                table: "SubCategorys",
                column: "ParentCategorysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "BillDetailCheckoutProducts");

            migrationBuilder.DropTable(
                name: "CommentProducts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ListProductImages");

            migrationBuilder.DropTable(
                name: "MassProducts");

            migrationBuilder.DropTable(
                name: "BillCheckoutProducts");

            migrationBuilder.DropTable(
                name: "DetailProducts");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "SaleOffProducts");

            migrationBuilder.DropTable(
                name: "SmallSubCategorys");

            migrationBuilder.DropTable(
                name: "SubCategorys");

            migrationBuilder.DropTable(
                name: "ParentCategorys");
        }
    }
}
