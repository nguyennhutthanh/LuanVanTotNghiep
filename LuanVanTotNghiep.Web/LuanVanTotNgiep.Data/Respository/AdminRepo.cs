using LuanVanTotNghiep.DTOs;
using Microsoft.EntityFrameworkCore;
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

		public async Task<bool> AddAdmin(AccountDTO taikhoan)
		{
			try
			{
				await db.Accounts.AddAsync(taikhoan);
				await db.SaveChangesAsync();
				return true;
			}

			catch
			{
				return false;
			}
		}
		public AccountDTO getAdminByUsername(string Username)
		{
			return db.Accounts.Where(x => x.UserName == Username).FirstOrDefault();
		}
		public AccountDTO Find(int id)
		{
			return db.Accounts.Find(id);
		}
		public void Delete(int id)
		{
			  db.Accounts.Remove(db.Accounts.Find(id));
		}
		public async Task<IEnumerable<AccountDTO>> ShoListAdmin()
		{
			var list = await db.Accounts
				.OrderByDescending(s => s.Id)
				.Where(s => s.IsBlocked == false)
				.ToListAsync();
			return list;
		}
		public async Task<IEnumerable<AccountDTO>> ShoListBlockAdmin()
		{
			var list = await db.Accounts
				.OrderByDescending(s => s.Id)
				.Where(s => s.IsBlocked == true)
				.ToListAsync();
			return list;
		}
		public async Task<AccountDTO> BlockAdmin(int id)
		{
			var block = await db.Accounts.Where(s => s.Id == id).SingleOrDefaultAsync();
			if (block != null)
			{
				block.IsBlocked = true;
			}
			await db.SaveChangesAsync();
			return block;
		}
		public async Task<AccountDTO> UnBlockAdmin(int id)
		{
			var block = await db.Accounts.Where(s => s.Id == id).SingleOrDefaultAsync();
			if (block != null)
			{
				block.IsBlocked = false;
			}
			await db.SaveChangesAsync();
			return block;
		}
		public async Task<AccountDTO> UpdateAdmin(AccountDTO admin)
		{
			var obj = await db.Accounts.FindAsync(admin.Id);
			if (obj != null)
			{
				obj.UserName = admin.UserName;
				obj.UrlAvatar = admin.UrlAvatar;
				obj.Email = admin.Email;
				obj.PhoneNumber = admin.PhoneNumber;
				obj.IsBlocked = admin.IsBlocked;
				obj.IsSuperAdmin = admin.IsSuperAdmin;
			}
			return admin;
		}
	}
}
