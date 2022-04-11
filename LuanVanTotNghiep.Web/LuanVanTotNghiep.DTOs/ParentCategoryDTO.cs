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
	public class ParentCategoryDTO
	{
		public ParentCategoryDTO()
		{
			SubCategoryNavigation = new  HashSet<SubCategoryDTO>();
		}
		[Key]
		public int Id { get; set; }
		public string NameCategory { get; set; }
		public string UrlCategory { get; set; }
		[NotMapped]
		public IFormFile ImageCategory { get; set; }
		public int? IdSubCategory { get; set; }
		public virtual ICollection<SubCategoryDTO> SubCategoryNavigation { get; set; }
	}
}
