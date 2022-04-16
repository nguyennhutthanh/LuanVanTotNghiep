using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class BillCheckoutProductRepo:RepositoryBase
	{
		public BillCheckoutProductRepo() : base() { }
		public BillCheckoutProductRepo(LuanVanTotNghiepDbContext _db) : base(_db) { } 
	}
}
