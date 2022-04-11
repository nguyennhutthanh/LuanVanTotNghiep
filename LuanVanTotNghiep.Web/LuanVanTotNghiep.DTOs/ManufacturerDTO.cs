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
	public class ManufacturerDTO
	{
		public ManufacturerDTO()
		{
			ManufacturerNavigation = new HashSet<DetailProductDTO>();
		}
		[Key]
		public int Id { get; set; }
		public string NameManufacturer { get; set; }
		public string UrlManufacturer { get; set; }
		[NotMapped]
		public IFormFile ImageManufacturer { get; set; }
		public ICollection<DetailProductDTO> ManufacturerNavigation { get; set; }
	}
}
