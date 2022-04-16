using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class DetailProductRepo :RepositoryBase
	{
		public DetailProductRepo() : base() { }
		public DetailProductRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }

	}
}
