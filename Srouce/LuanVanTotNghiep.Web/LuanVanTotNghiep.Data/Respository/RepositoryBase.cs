using LuanVanTotNghiep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class RepositoryBase
	{
		protected LuanVanTotNghiepDbContext db;
		public RepositoryBase()
		{
			db = new LuanVanTotNghiepDbContext();
		}
		public RepositoryBase(LuanVanTotNghiepDbContext _db)
		{
			db = _db;
		}
		public void Save()
		{
			db.SaveChanges();
		}
		public async void SaveChangesAsync()
		{
			await db.SaveChangesAsync();
		}
	}
}
