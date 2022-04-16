using LuanVanTotNghiep.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class CustomerRepo:RepositoryBase
	{
		public CustomerRepo() : base() { }
		public CustomerRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }

		public async Task<List<CustomerDTO>> ListUser()
		{
			var list = await db.Customers
				.OrderByDescending(s => s.IdCustomer)
				.Where(s => s.IsBlocked == false)
				.Select(s => new CustomerDTO()
				{
					Phone = s.Phone,
					Address = s.Address,
					Email = s.Email,
					FullName = s.FullName,
					IsBlocked = s.IsBlocked,
					CreateDate = s.CreateDate,
					PassWp = s.PassWp,
					UserName = s.UserName,
					IdCustomer = s.IdCustomer
				}).ToListAsync();
			return list;
		}
		public async Task<List<CustomerDTO>> ListBlockUser()
		{
			var list = await db.Customers
				.OrderByDescending(s => s.IdCustomer)
				.Where(s => s.IsBlocked == true)
				.Select(s => new CustomerDTO()
				{
					Phone = s.Phone,
					Address = s.Address,
					Email = s.Email,
					FullName = s.FullName,
					IsBlocked = s.IsBlocked,
					CreateDate = s.CreateDate,
					PassWp = s.PassWp,
					UserName = s.UserName,
					IdCustomer = s.IdCustomer
				}).ToListAsync();
			return list;
		}
		public async Task<CustomerDTO> BlockUser(int id)
		{
			var block = await db.Customers.Where(s => s.IdCustomer == id).SingleOrDefaultAsync();
			if (block != null)
			{
				block.IsBlocked = true;
			}
			await db.SaveChangesAsync();
			return block;
		}
		public async Task<CustomerDTO> UnBlockUser(int id)
		{
			var block = await db.Customers.Where(s => s.IdCustomer == id).SingleOrDefaultAsync();
			if (block != null)
			{
				block.IsBlocked = false;
			}
			await db.SaveChangesAsync();
			return block;
		}
		public void Delete(int id)
		{
			db.Customers.Remove(db.Customers.Find(id));
		}
	}
}
