using LuanVanTotNghiep.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Data.Respository
{
	public class CommentRepo:RepositoryBase
	{
		public CommentRepo() : base() { }
		public CommentRepo(LuanVanTotNghiepDbContext _db) : base(_db) { }
		#region Client
		public async void CreateComment(CommentProductDTO comments)
		{
			await db.CommentProducts.AddAsync(comments);
			db.SaveChanges();
		}
		public async Task<List<CommentProductDTO>> ListComment(int id)
		{
			var list = await db.CommentProducts
				.Where(x => x.IdProduct == id)
				.OrderByDescending(x => x.Id)
				.Select(s => new CommentProductDTO()
				{
					Id = s.Id,
					Email = s.Email,
					FullName = s.FullName,
					Messages = s.Messages,
					IdProduct = s.IdProduct,
					EvaluationDate = s.EvaluationDate,
					Status = s.Status,
					BlockComments = s.BlockComments,
					IsComments = s.IsComments
				})
				.Take(5).ToListAsync();
			return list;
		}
		public async Task<DetailProductDTO> getProduct(int id)
		{
			return await db.DetailProducts.SingleOrDefaultAsync(x => x.Id == id);
		}
		#endregion

		#region Admin
		// show list coment không khóa
		public async Task<List<CommentProductDTO>> ShowListComment()
		{
			var list = await db.CommentProducts
				.OrderByDescending(x => x.Id)
				.Where(s => s.BlockComments == false)
				.Select(s => new CommentProductDTO()
				{
					Id = s.Id,
					Email = s.Email,
					FullName = s.FullName,
					Messages = s.Messages,
					IdProduct = s.IdProduct,
					EvaluationDate = s.EvaluationDate,
					Status = s.Status,
					BlockComments = s.BlockComments,
					IsComments = s.IsComments
				}).ToListAsync();
			return list;
		}
		// show list coment đã khóa
		public async Task<List<CommentProductDTO>> ShowListSpam()
		{
			var list = await db.CommentProducts
				.OrderByDescending(x => x.Id)
				.Where(s => s.BlockComments == true)
				.Select(s => new CommentProductDTO()
				{
					Id = s.Id,
					Email = s.Email,
					IsComments = s.IsComments,
					IdProduct = s.IdProduct,
					FullName = s.FullName,
					EvaluationDate = s.EvaluationDate,
					Messages = s.Messages,
					Status = s.Status,
					BlockComments = s.BlockComments
				}).ToListAsync();
			return list;
		}
		// xem review comment
		public async Task<CommentProductDTO> ViewComment(int id)
		{
			var view = await db.CommentProducts
				.Where(s => s.Id == id)
				.Select(s => new CommentProductDTO()
				{
					Id = s.Id,
					Email = s.Email,
					IsComments = s.IsComments,
					IdProduct = s.IdProduct,
					FullName = s.FullName,
					EvaluationDate = s.EvaluationDate,
					Messages = s.Messages,
					Status = s.Status,
					BlockComments = s.BlockComments
				})
				.SingleOrDefaultAsync();
			return view;
		}
		//chặn bình luận
		public async Task<CommentProductDTO> SpamBinhLuan(int id)
		{
			var find = await db.CommentProducts.Where(s => s.Id == id).SingleOrDefaultAsync();
			if (find != null)
			{
				find.BlockComments = true;
			}
			await db.SaveChangesAsync();
			return find;
		}
		// mở chặn bình luận
		public async Task<CommentProductDTO> OpenSpamBinhLuan(int id)
		{
			var find = await db.CommentProducts.Where(s => s.Id == id).SingleOrDefaultAsync();
			if (find != null)
			{
				find.BlockComments = false;
			}
			await db.SaveChangesAsync();
			return find;
		}
		public async Task<CommentProductDTO> SetOpenView(int id)
		{
			var open = await db.CommentProducts.Where(s => s.Id == id).SingleOrDefaultAsync();
			if (open != null)
			{
				open.Status = true;
			}
			await db.SaveChangesAsync();
			return open;
		}
		public void DeleteComment(int id)
		{
			db.CommentProducts.Remove(db.CommentProducts.Find(id));
			db.SaveChanges();
		}
		#endregion
	}
}
