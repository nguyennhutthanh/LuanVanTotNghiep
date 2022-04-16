using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class UserRepo:RepositoryBase
	{
		public UserRepo() : base() { }
		public UserRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }
	}
}
