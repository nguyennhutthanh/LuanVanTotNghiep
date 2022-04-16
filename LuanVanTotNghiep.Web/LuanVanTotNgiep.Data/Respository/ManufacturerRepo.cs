using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class ManufacturerRepo:RepositoryBase
	{
		public ManufacturerRepo() : base() { }
		public ManufacturerRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }
		
	}
}
