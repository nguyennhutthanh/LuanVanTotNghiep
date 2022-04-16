using LuanVanTotNghiep.Data.Respository;
using LuanVanTotNghiep.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanVanTotNghiep.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentController : ControllerBase
	{
		CommentRepo commentRepo;
		IWebHostEnvironment _host;
		public CommentController(IWebHostEnvironment host)
		{
			_host = host;
			commentRepo = new CommentRepo();
		}

		[HttpGet(template: "listbinhluan")]
		public async Task<IActionResult> GetListBinhLuan()
		{
			var lists = await commentRepo.ShowListComment();
			if (lists != null)
			{
				return Ok(lists);
			}
			else
			{
				return Ok(false);
			}
		}
		[HttpGet(template: "listspam")]
		public async Task<IActionResult> GetListSpam()
		{
			var listSpam = await commentRepo.ShowListSpam();
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
			await commentRepo.SetOpenView(id);
			var view = await commentRepo.ViewComment(id);
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
			await commentRepo.SpamBinhLuan(id);
			return Ok(true);
		}
		[HttpGet(template: "mobinhluan/{id}")]
		public async Task<IActionResult> MoBinhLuan(int id)
		{
			await commentRepo.OpenSpamBinhLuan(id);
			return Ok(true);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBinhLuan(int id)
		{
			commentRepo.DeleteComment(id);
			commentRepo.SaveChangesAsync();
			return Ok(true);
		}
		[HttpGet(template: "ClientListBinhLuan/{id}")]
		public async Task<IActionResult> ClientGetListBinhLuan(int id)
		{
			var listcomment = await commentRepo.ListComment(id);
			if (listcomment == null)
			{
				return Ok(false);
			}
			return Ok(listcomment);
		}
		[HttpPost]
		public async Task<IActionResult> AddCommentProduct([FromForm] CommentProductDTO comment)
		{
			var idcomment = await commentRepo.getProduct(comment.Id);
			CommentProductDTO list = new CommentProductDTO();
			{
				list.FullName = comment.FullName;
				list.Email = comment.Email;
				list.Messages = comment.Messages;
				list.IsComments = idcomment;
				list.EvaluationDate = DateTime.Now;
			}
			if (ModelState.IsValid)
			{
				commentRepo.CreateComment(list);
				commentRepo.Save();
				return Ok(true);
			}
			return Ok(false);
		}
	}
}
