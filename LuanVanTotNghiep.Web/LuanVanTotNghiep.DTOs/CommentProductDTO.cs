using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class CommentProductDTO
	{
		public CommentProductDTO()
		{
			IsComments = new DetailProductDTO();
		}
		[Key]
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Messages { get; set; }
		public DateTime EvaluationDate { get; set; } // ngày comment
		public bool? Status { get; set; } // xem hay chưa
		public bool? BlockComments { get; set; } // chặn hay chưa chặn comment
		public int IdProduct { get; set; }
		[ForeignKey("IdProduct")]
		public DetailProductDTO IsComments { get; set; }
	}
}
