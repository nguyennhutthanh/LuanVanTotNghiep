using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
    public class DetailProductDTO
    {
        public DetailProductDTO()
		{
            Manufacturers = new ManufacturerDTO();
            ProductBrands = new ProductBrandsDTO();
            SaleOffProduct = new SaleOffProductDTO();
            SmallSubCategory = new SmallSubCategoryDTO();
            MassNavigation = new HashSet<MassProductDTO>();
            CommentsNavigation = new HashSet<CommentProductDTO>();
            DetaiCheckoutNavigation = new HashSet<BillDetailCheckoutProductDTO>();
            ListImageNavigation = new HashSet<ListProductImageDTO>();
        }
        [Key]
        public int Id { get; set; }
        public string CodeProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public string UrlImageProduct { get; set; }
        public string Review { get; set; }
        public int AmountProduct { get; set; }
        public DateTime ProductAddedDate { get; set; } // Ngày thêm //
        public string Description { get; set; }
        public string OriginProduct { get; set; }
        public DateTime ExpiryProduct { get; set; } // hạn sử dụng //
        public double PriceSaleOffProduct { get; set; } //
        public double MassProduct { get; set; } // Khối lượng gam ký lô gam
        public bool? StatusProduct { get; set; }
        [NotMapped]
        public IFormFile ImageProduct { get; set; }
        [NotMapped]
        public List<IFormFile> ListImageProduct { get; set; }
        public int? IdSmallSubCategory { get; set; }
        public int? IdManufacturers { get; set; }
        public int? IdComment { get; set; }
        public int? IdBrands { get; set; }
        public int? IdDatHang { get; set; }
        public int? IdListImage { get; set; }
        public int? IdSaleOff { get; set; }
        public int? IdMass { get; set; }
        public virtual ManufacturerDTO Manufacturers { get; set; }
        public virtual ProductBrandsDTO ProductBrands { get; set; }
        public virtual SaleOffProductDTO SaleOffProduct { get; set; }
        public virtual SmallSubCategoryDTO SmallSubCategory { get; set; }
        public virtual ICollection<MassProductDTO> MassNavigation {get; set;}
        public virtual ICollection<CommentProductDTO> CommentsNavigation { get; set; }
        public virtual ICollection<BillDetailCheckoutProductDTO> DetaiCheckoutNavigation { get; set; }
        public ICollection<ListProductImageDTO> ListImageNavigation { get; set; }
    }
}
