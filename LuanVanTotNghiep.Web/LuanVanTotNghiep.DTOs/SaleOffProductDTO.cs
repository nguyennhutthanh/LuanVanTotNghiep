using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class SaleOffProductDTO
	{
		public SaleOffProductDTO()
		{
			SaleOffProductNavigation = new HashSet<DetailProductDTO>();
		}
		[Key]
		public int Id { get; set; }
		public double SaleOff { get; set; }
		public DateTime PromotionDay { get; set; }
		public DateTime PromotionExpirationDate { get; set; }
		public ICollection<DetailProductDTO> SaleOffProductNavigation { get; set; }

	}
}
