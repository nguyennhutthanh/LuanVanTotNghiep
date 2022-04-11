using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class AdminRepo: RepositoryBase
	{
		public AdminRepo() : base() { }
		public AdminRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }
	}
}
