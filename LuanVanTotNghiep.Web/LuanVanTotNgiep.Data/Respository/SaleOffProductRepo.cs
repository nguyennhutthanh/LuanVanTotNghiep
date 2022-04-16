using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class SaleOffProductRepo: RepositoryBase
	{
		public SaleOffProductRepo() : base() { }
		public SaleOffProductRepo(LuanVanTotNghiepDbContext _db ) : base(_db) { } 
	}
}
