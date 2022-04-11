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
	public class SmallSubCategoryDTO
	{
		public SmallSubCategoryDTO()
		{
			SubCategorys = new SubCategoryDTO();
			ProductNavigation = new  HashSet<DetailProductDTO>();
		}
		[Key]
		public int Id { get; set; }
		public string NameCategory { get; set; }
		public string UrlCategory { get; set; }
		[NotMapped]
		public IFormFile ImageCategory { get; set; }
		public int? IdProduct { get; set; }
		public int? IdSubCategory { get; set; }
		public virtual SubCategoryDTO SubCategorys { get; set; }
		public virtual ICollection<DetailProductDTO> ProductNavigation { get; set; }
	}
}
