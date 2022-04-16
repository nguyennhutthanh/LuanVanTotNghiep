using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class CheckoutProductRepo:RepositoryBase
	{
		public CheckoutProductRepo() : base() { }
		public CheckoutProductRepo(LuanVanTotNghiepDbContext _db): base(_db) { }
	}
}
