using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuanVanTotNghiep.Data.Respository;
using LuanVanTotNghiep.DTOs;
using Microsoft.AspNetCore.Hosting;
using LuanVanTotNghiep.Web.ViewModel;

namespace LuanVanTotNghiep.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BinhLuanController : ControllerBase
	{
		IWebHostEnvironment _host;
		public BinhLuanRepo binhluanRepo;
		public BinhLuanController(IWebHostEnvironment host)
		{
			_host = host;
			binhluanRepo = new BinhLuanRepo();
		}
		[HttpGet(template: "listbinhluan")]
		public async Task<IActionResult> GetListBinhLuan()
		{
			var lists = await binhluanRepo.ShowListComment();
			if(lists != null)
			{
				return Ok(lists);
			}else
			{
				return Ok(false);
			}	
		}
		[HttpGet(template: "listspam")]
		public async Task<IActionResult> GetListSpam()
		{
			var listSpam = await binhluanRepo.ShowListSpam();
			if (listSpam != null)
			{
				return Ok(listSpam);
			}
			else
			{
				return Ok(false);
			}
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetViewBinhLuan(int id)
		{
			await binhluanRepo.SetOpenView(id);
			var view = await binhluanRepo.ViewComment(id);
			if (view != null)
			{
				return Ok(view);
			}
			else
			{
				return Ok(false);
			}
		}
		[HttpGet(template: "khoabinhluan/{id}")]
		public async Task<IActionResult> KhoaBinhLuan(int id)
		{
			await binhluanRepo.SpamBinhLuan(id);
			return Ok(true);
		}
		[HttpGet(template: "mobinhluan/{id}")]
		public async Task<IActionResult> MoBinhLuan(int id)
		{
			await binhluanRepo.OpenSpamBinhLuan(id);
			return Ok(true);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBinhLuan(int id)
		{
			binhluanRepo.DeleteComment(id);
			binhluanRepo.SaveChangesAsync();
			return Ok(true);
		}
		[HttpGet(template: "ClientListBinhLuan/{id}")]
		public async Task<IActionResult> ClientGetListBinhLuan(int id)
		{
			var listcomment = await binhluanRepo.ListComment(id);
			if(listcomment == null)
			{
				return Ok(false);
			}
			return Ok(listcomment);
		}
		[HttpPost]
		public async Task<IActionResult> AddCommentProduct([FromForm] AddComment comment)
		{
			var idcomment = await binhluanRepo.getProduct(comment.Id);
			CommentDTO list = new CommentDTO();
			{
				list.Name = comment.Name;
				list.Email = comment.Email;
				list.NoiDung = comment.NoiDung;
				list.IdComment = idcomment;
				list.NgayBinhLuan = DateTime.Now;
			}
			if (ModelState.IsValid)
			{
				binhluanRepo.CreateComment(list);
				binhluanRepo.Save();
				return Ok(true);
			}
			return Ok(false);
		}
	}
}
