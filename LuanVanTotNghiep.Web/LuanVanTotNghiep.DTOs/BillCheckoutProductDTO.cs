using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class BillCheckoutProductDTO
	{
        public BillCheckoutProductDTO()
		{
            DetailCheckoutNavigation = new HashSet<BillDetailCheckoutProductDTO>();
        }
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public double TotalBill { get; set; }
        public int TotalProducts { get; set; }
        public bool? Status { get; set; } // đã xem hay chưa xem
        public int? OrderStatus { get; set; } // trạng thái dơn hàng
        public DateTime OrderDate { get; set; }

        public virtual ICollection<BillDetailCheckoutProductDTO> DetailCheckoutNavigation { get; set; }
    }
}
