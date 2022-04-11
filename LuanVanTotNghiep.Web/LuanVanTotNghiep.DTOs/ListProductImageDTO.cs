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
	public class ListProductImageDTO
	{
		public ListProductImageDTO()
		{
			IsProductImage = new DetailProductDTO();
		}
		[Key]
		public int Id { get; set; }
		public string NameImage { get; set; }
		public string UrlImage { get; set; }
		[NotMapped]
		public IFormFile Image { get; set; }
		public DetailProductDTO IsProductImage { get; set; }
	}
}
