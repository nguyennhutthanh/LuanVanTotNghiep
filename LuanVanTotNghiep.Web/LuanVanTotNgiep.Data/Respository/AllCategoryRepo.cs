using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class AllCategoryRepo:RepositoryBase
	{
		public AllCategoryRepo() : base() { }
		public AllCategoryRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }

	}
}
