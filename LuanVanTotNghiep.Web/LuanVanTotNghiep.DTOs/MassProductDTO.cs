using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.DTOs
{
	public class MassProductDTO
	{
		public MassProductDTO()
		{
			MassProducts = new DetailProductDTO();
		}
		[Key]
		public int Id { get; set; }
		public string UnitMass { get; set; }
		public double MassProduct { get; set; }
		public virtual DetailProductDTO MassProducts { get; set; }
	}
}
