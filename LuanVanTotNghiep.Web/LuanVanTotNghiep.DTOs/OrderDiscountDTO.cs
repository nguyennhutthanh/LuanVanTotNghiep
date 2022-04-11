using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class OrderDiscountDTO
	{
		[Key]
		public int Id { get; set; }
		public string DiscountCode { get; set; }
		public double SaleOffPercent { get; set; }
		public DateTime PromotionDay { get; set; }
		public DateTime PromotionExpirationDate { get; set; }
	}
}
