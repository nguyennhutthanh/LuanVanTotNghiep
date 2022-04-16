using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class MassProductRepo: RepositoryBase
	{
		public MassProductRepo(): base() { }
		public MassProductRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }
	}
}
