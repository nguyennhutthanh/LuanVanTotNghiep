using LuanVanTotNghiep.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LuanVanTotNghiep.Data
{
	public class LuanVanTotNghiepDbContext : DbContext
	{
		public LuanVanTotNghiepDbContext() { }
		public LuanVanTotNghiepDbContext(DbContextOptions<LuanVanTotNghiepDbContext> options) : base(options) { }
		public virtual DbSet<AccountDTO> Accounts { get; set; }
		public virtual DbSet<BillCheckoutProductDTO> BillCheckoutProducts { get; set; }
		public virtual DbSet<BillDetailCheckoutProductDTO> BillDetailCheckoutProducts { get; set; }
		public virtual DbSet<CommentProductDTO> CommentProducts { get; set; }
		public virtual DbSet<ContactDTO> Contacts { get; set; }
		public virtual DbSet<DetailProductDTO> DetailProducts { get; set; }
		public virtual DbSet<ListProductImageDTO> ListProductImages { get; set; }
		public virtual DbSet<ManufacturerDTO> Manufacturers { get; set; }
		public virtual DbSet<MassProductDTO> MassProducts { get; set; }
		public virtual DbSet<ParentCategoryDTO> ParentCategorys { get; set; }
		public virtual DbSet<ProductBrandsDTO> ProductBrands { get; set; }
		public virtual DbSet<SaleOffProductDTO> SaleOffProducts { get; set; }
		public virtual DbSet<SmallSubCategoryDTO> SmallSubCategorys { get; set; }
		public virtual DbSet<SubCategoryDTO> SubCategorys { get; set; }
		public virtual DbSet<CustomerDTO> Customers { get; set; }
		public virtual DbSet<OrderDiscountDTO> OrderDiscount { get; set; }
 		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var Builder = new ConfigurationBuilder()
					.AddJsonFile("appsettings.json", optional: false)
					.Build();
			optionsBuilder.UseSqlServer(Builder.GetConnectionString("LuanVanTotNghiep"));
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BillDetailCheckoutProductDTO>().HasKey(x => new { x.IdCheckout, x.IdProduct });
		}
	}
}
