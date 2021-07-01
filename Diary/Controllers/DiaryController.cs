using Diary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Controllers
{
	public class DiaryController : Controller
	{
		private readonly DiaryEntryContext _context;

		public DiaryController(DiaryEntryContext context)
		{
			_context = context;
		}

		// GET: Diary
		public ActionResult Index()
		{
			return View(_context.GetAllEntries());
		}

		// GET: Diary/Details/5
		public ActionResult Details(int id)
		{
			return View(_context.Get(id));
		}

		// GET: Diary/Create
		public ActionResult Create()
		{
			return View(new DiaryEntryModel());
		}

		// POST: Diary/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(DiaryEntryModel entry)
		{
			if (ModelState.IsValid)
			{
				_context.Add(entry);
				return RedirectToAction(nameof(Index));
			}
			return View(entry);
		}

		// GET: Diary/Delete/5
		public ActionResult Delete(int id)
		{
			return View(_context.Get(id));
		}

		// POST: Diary/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, DiaryEntryModel entry)
		{
			_context.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
