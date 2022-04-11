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
	public class ProductBrandsDTO
	{
		public ProductBrandsDTO()
		{
			ProductBrandsNavigation = new HashSet<DetailProductDTO>();
		}
		[Key]
		public int Id { get; set; }
		public string NameBrands { get; set; }
		public string UrlBrands { get; set; }
		[NotMapped]
		public IFormFile ImageBrands { get; set; }
		public ICollection<DetailProductDTO> ProductBrandsNavigation { get; set; }
	}
}
