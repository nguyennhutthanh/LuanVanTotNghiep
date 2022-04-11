using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class BillDetailCheckoutProductDTO
	{
		public BillDetailCheckoutProductDTO()
		{
			BillDetailCheckout = new BillCheckoutProductDTO();
			BillDetailProduct = new DetailProductDTO();
		}
		public int AmountProduct { get; set; }
		public double TotalBill { get; set; }
		public int IdCheckout { get; set; }
		public int IdProduct { get; set; }
		[ForeignKey("IdCheckout")]
		public BillCheckoutProductDTO BillDetailCheckout { get; set; }
		[ForeignKey("IdProduct")]
		public virtual DetailProductDTO BillDetailProduct { get; set; }
	}
}
