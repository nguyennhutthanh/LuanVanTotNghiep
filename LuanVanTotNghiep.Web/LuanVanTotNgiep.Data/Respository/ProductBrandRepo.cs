using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class ProductBrandRepo: RepositoryBase
	{
		public ProductBrandRepo() : base() { }
		public ProductBrandRepo(LuanVanTotNghiepDbContext _db): base(_db) { }
		
	}
}
