using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class OrderDiscountRepo:RepositoryBase
	{
		public OrderDiscountRepo() :base() { }
		public OrderDiscountRepo(LuanVanTotNghiepDbContext _db): base(_db) { }
		
	}
}
