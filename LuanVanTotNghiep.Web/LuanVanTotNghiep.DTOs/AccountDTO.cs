using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class AccountDTO
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(100)]
		[Required(ErrorMessage = "Trường này Không được trống")]
		public string UserName { get; set; }
		[MaxLength(200)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[MaxLength(200)]
		[NotMapped]
		public string EnterPassword { get; set; }
		public string Salt { get; set; }
		public string Email { get; set; }
		public string UrlAvatar { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public string FullName { get; set; }
		public bool IsSuperAdmin { get; set; }
		public bool IsPersion { get; set; }
		public bool IsBlocked { get; set; }
		[NotMapped]
		public IFormFile ImageAvatar { get; set; }
	}
}
