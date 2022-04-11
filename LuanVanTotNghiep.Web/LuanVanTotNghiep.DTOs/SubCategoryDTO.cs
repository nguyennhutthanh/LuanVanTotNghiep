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
	public class SubCategoryDTO
	{
		public SubCategoryDTO()
		{
			ParentCategorys = new ParentCategoryDTO();
			SmallSubCategoryNavigation = new HashSet<SmallSubCategoryDTO>();
		}
		[Key]
		public int Id { get; set; }
		public string NameCategory { get; set; }
		public string UrlCategory { get; set; }
		[NotMapped]
		public IFormFile ImageCategory { get; set; }
		public int? IdSmallSub { get; set; }
		public int? IdParentCategory { get; set; }
		public virtual ParentCategoryDTO ParentCategorys { get; set; }
		public virtual ICollection<SmallSubCategoryDTO> SmallSubCategoryNavigation { get; set; }
	}
}
