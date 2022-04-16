using LuanVanTotNghiep.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class ContactRepo:RepositoryBase
	{
		public ContactRepo() : base() { }
		public ContactRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }

		public async void AddContact(ContactDTO contact)
		{
			await db.Contacts.AddAsync(contact);
			await db.SaveChangesAsync();
		}
		public async Task<List<ContactDTO>> ListLienHe()
		{
			var list = await db.Contacts
				.OrderByDescending(s => s.Id)
				.Select(s => new ContactDTO()
				{
					Address = s.Address,
					PhoneNumber = s.PhoneNumber,
					Email = s.Email,
					FullName = s.FullName,
					Message = s.Message,
					Status = s.Status,
					Id = s.Id
				}).ToListAsync();
			return list;
		}
		public async Task<ContactDTO> SetViewTrangThai(int id)
		{
			var find = db.Contacts.Where(s => s.Id == id).SingleOrDefault();
			if (find != null)
			{
				find.Status = true;
			}
			db.SaveChanges();
			return find;
		}
		public async Task<ContactDTO> ViewLienHe(int id)
		{
			var list = await db.Contacts
				.Where(s => s.Id == id)
				.Select(s => new ContactDTO()
				{
					Address = s.Address,
					PhoneNumber = s.PhoneNumber,
					Email = s.Email,
					FullName = s.FullName,
					Message = s.Message,
					Status = s.Status,
					Id = s.Id
				})
				.SingleOrDefaultAsync();
			return list;
		}
		public void deleteLienHe(int id)
		{
			var del = db.Contacts.Find(id);
			db.Contacts.Remove(del);
			db.SaveChanges();
		}
	}
}
