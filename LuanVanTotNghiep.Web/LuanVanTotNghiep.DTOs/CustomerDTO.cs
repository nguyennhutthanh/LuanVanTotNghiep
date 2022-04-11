using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class CustomerDTO
	{
		[Key]
		public int IdCustomer { get; set; }
		public string FullName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public string PassWp { get; set; }
		public bool IsBlocked { get; set; }
		public DateTime CreateDate { get; set; } // ngày tạo account
	}
}
